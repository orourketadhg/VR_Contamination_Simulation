﻿using com.TUDublin.VRContaminationSimulation.DOTS.Components.Items;
using Unity.Assertions;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Systems;
using Unity.Transforms;

namespace com.TUDublin.VRContaminationSimulation.DOTS.Systems {

    public class ItemCollectorSystem : SystemBase {

        private BuildPhysicsWorld _buildPhysicsWorld;
        private EndFixedStepSimulationEntityCommandBufferSystem _entityCommandBuffer;

        protected override void OnCreate() {
            _buildPhysicsWorld = World.GetOrCreateSystem<BuildPhysicsWorld>();
            _entityCommandBuffer = World.GetOrCreateSystem<EndFixedStepSimulationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate() {
            var physicsWorld = _buildPhysicsWorld.PhysicsWorld;
            var ecb = _entityCommandBuffer.CreateCommandBuffer();

            Entities
                .WithName("ItemPickup")
                .WithoutBurst()
                .ForEach((Entity entity, ref InteractableCollectorData collector, in LocalToWorld ltw) => {
                    switch (collector.EnableCollector) {
                        // attempt to pickup item
                        case 1 when collector.collectedItem == Entity.Null: {
                            var overlapSpherePosition = ltw.Position + ( -ltw.Right ) * collector.collectorPositionOffset;
                            float overlapSphereRadius = collector.collectorRadius;
                            var overlapSphereHits = new NativeList<DistanceHit>(Allocator.Temp);
                            var overlapSphereFilter = new CollisionFilter() {
                                BelongsTo = ~0u,                // belongs to everything
                                CollidesWith = ( 1u << 12 ),    // collide with layer 12
                                GroupIndex = 0
                            };

                            if (physicsWorld.OverlapSphere(overlapSpherePosition, overlapSphereRadius, ref overlapSphereHits, overlapSphereFilter)) {
                                // get the index of the closest entity
                                int otherIndex = 0;
                                if (overlapSphereHits.Length > 1) {
                                    for (int i = 1; i < overlapSphereHits.Length; i++) {
                                        if (overlapSphereHits[i].Distance > overlapSphereHits[otherIndex].Distance) {
                                            otherIndex = i;
                                        }
                                    }
                                }
                                
                                var other = overlapSphereHits[otherIndex].Entity;
                                collector.collectedItem = other;
                                var otherInteractableData = GetComponent<InteractableItemData>(other);

                                // calculate held item position and rotation
                                var otherPosition = otherInteractableData.itemPositionOffset + collector.collectedItemPositionOffset;
                                var otherRotation = otherInteractableData.itemRotationOffset;
                                var otherLtw = new float4x4(float3x3.Euler(otherRotation, math.RotationOrder.XYZ), otherPosition);
                                
                                // update collision filter
                                var otherCollider = GetComponent<PhysicsCollider>(other);
                                var clone = otherCollider.Value.Value.Clone();
                                var filter = new CollisionFilter() {
                                    BelongsTo = ( 1u << 12 ),
                                    CollidesWith = ~( 1u << 11 ),
                                    GroupIndex = 0
                                };
                                
                                unsafe {
                                    var clonePtr = (ColliderHeader*) clone.GetUnsafePtr();
                                    clonePtr->Filter = filter;
                                }

                                // set other as child of collector
                                ecb.AddComponent(other, new Parent() {Value = entity});
                                ecb.AddComponent(other, new LocalToParent() {Value = otherLtw});
                                ecb.SetComponent(other, new PhysicsCollider() {Value = clone});
                                ecb.RemoveComponent(other, new ComponentTypes(typeof(PhysicsMass),typeof(PhysicsVelocity), typeof(PhysicsDamping)));
                            }
                            break;
                        }
                        case 0 when collector.collectedItem != Entity.Null:
                            // un-parent entity + enable physics
                            var heldItem = collector.collectedItem;
                            ecb.RemoveComponent(heldItem, typeof(Parent));
                            ecb.RemoveComponent(heldItem, typeof(LocalToParent));
                            
                            collector.collectedItem = Entity.Null;
                            break;
                    }
                }).Schedule();
            
            _entityCommandBuffer.AddJobHandleForProducer(Dependency);
        }

        private static void SetItemCollisionFilter(ref BlobAssetReference<Collider> collider, uint belongsTo, uint disabled) {
            
        }
    }

}