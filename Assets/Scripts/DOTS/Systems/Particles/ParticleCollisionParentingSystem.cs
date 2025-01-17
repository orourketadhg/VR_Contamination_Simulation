﻿using com.TUDublin.VRContaminationSimulation.Common.Enums;
using com.TUDublin.VRContaminationSimulation.DOTS.Components.Particles;
using com.TUDublin.VRContaminationSimulation.DOTS.Components.Physics;
using com.TUDublin.VRContaminationSimulation.DOTS.Components.Tags;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;

namespace com.TUDublin.VRContaminationSimulation.DOTS.Systems.Particles {
    
    /**
     * Attempt 2 at particle sticking
     */
    public class ParticleCollisionParentingSystem : SystemBase {

        private EndFixedStepSimulationEntityCommandBufferSystem _entityCommandBufferSystem;

        protected override void OnCreate() {
            _entityCommandBufferSystem = World.GetOrCreateSystem<EndFixedStepSimulationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate() {

            var ecb = _entityCommandBufferSystem.CreateCommandBuffer();

            Entities
                .WithName("VirusParticleInitialSticking")
                .WithBurst()
                .WithAll<VirusParticleData, ActiveTag>()
                .WithNone<Parent, LocalToParent>()
                .ForEach((Entity entity, int entityInQueryIndex, ref PhysicsVelocity pv, ref DecayingParticleData decayData, ref BrownianMotionData motionData, in DynamicBuffer<StatefulCollisionEvent> collisionBuffer) => {
                    if (collisionBuffer.IsEmpty) return;

                    // get index of first enter state collision
                    int collisionIndex = -1;
                    for (int i = 0; i < collisionBuffer.Length; i++) {
                        if (collisionBuffer[i].CollisionState == CollisionEventState.Enter) {
                            collisionIndex = i;
                            break;
                        }
                    }
            
                    if (collisionIndex < 0 ) return;
                    
                    // var other = collisionBuffer[collisionIndex].GetOtherCollisionEntity(entity);
                    
                    pv = new PhysicsVelocity();
                    
                    // ecb.RemoveComponent<PhysicsVelocity>(entity);
                    // ecb.AddComponent(entity, new Parent() {Value = other});
                    // ecb.AddComponent(entity, new LocalToParent() );
                    
                    motionData.enabled = 0;
                    decayData.isDecayingParticle = 0;
                }).ScheduleParallel();

            // Entities
            //     .WithName("stickingTest")
            //     .WithBurst()
            //     .ForEach((Entity entity, int entityInQueryIndex, ref LocalToWorld ltw, in DynamicBuffer<StatefulCollisionEvent> collisionBuffer, in TestTag test) => {
            //         if (collisionBuffer.IsEmpty) {
            //             return;
            //         }
            //         
            //         for (int i = 0; i < collisionBuffer.Length; i++) {
            //             if (collisionBuffer[i].CollisionState == CollisionEventState.Enter) {
            //                 var other = collisionBuffer[i].GetOtherCollisionEntity(entity);
            //
            //                 if (HasComponent<VirusParticleData>(other)) {
            //
            //                     if (HasComponent<Parent>(other) && HasComponent<LocalToParent>(other)) {
            //                         ecb.RemoveComponent<Parent>(other);
            //                         ecb.RemoveComponent<LocalToParent>(other);
            //                     }
            //
            //                     var decayingData = GetComponent<DecayingParticleData>(other);
            //                     var motionData = GetComponent<BrownianMotionData>(other);
            //
            //                     decayingData.isDecayingParticle = 0;
            //                     motionData.enabled = 0;
            //                     
            //                     ecb.SetComponent(other, decayingData);
            //                     ecb.SetComponent(other, motionData);
            //                     ecb.AddComponent(other, new Parent() {Value = entity});
            //                     ecb.AddComponent(other, new LocalToParent());
            //                     ecb.RemoveComponent<PhysicsVelocity>(other);
            //                     ecb.RemoveComponent<PhysicsMass>(other);
            //                     ecb.RemoveComponent<PhysicsDamping>(other);
            //                 }
            //             }
            //         }
            //     }).Schedule();

            // Entities
            //     .WithName("VirusParticleTransferSticking")
            //     .WithBurst()
            //     .WithAll<VirusParticleData, LocalToParent, ActiveTag>()
            //     .ForEach((Entity entity, int entityInQueryIndex, in DynamicBuffer<StatefulCollisionEvent> collisionBuffer, in Parent connectedBody) => {
            //         if (collisionBuffer.IsEmpty) {
            //             return;
            //         }
            //
            //         int collisionIndex = -1;
            //         for (int i = 0; i < collisionBuffer.Length; i++) {
            //             if (collisionBuffer[i].CollisionState == CollisionEventState.Enter && collisionBuffer[i].GetOtherCollisionEntity(entity) != connectedBody.Value) {
            //                 collisionIndex = i;
            //                 break;
            //             }
            //         }
            //
            //         if (collisionIndex < 0 ) {
            //             return;
            //         }
            //         
            //         var other = collisionBuffer[collisionIndex].GetOtherCollisionEntity(entity);
            //         
            //         ecb.RemoveComponent<Parent>(entityInQueryIndex, entity);
            //         ecb.RemoveComponent<LocalToParent>(entityInQueryIndex, entity);
            //         ecb.AddComponent(entityInQueryIndex, entity, new Parent() {Value = other});
            //         ecb.AddComponent(entityInQueryIndex,entity, new LocalToParent());
            //         stickyData.hasPosition = 0;
            //     }).ScheduleParallel();

            _entityCommandBufferSystem.AddJobHandleForProducer(Dependency);
            
        }
    }

}