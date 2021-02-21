﻿using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace com.TUDublin.VRContaminationSimulation.DOTS.Components.Items {

    [GenerateAuthoringComponent]
    public struct InteractableCollectorData : IComponentData {
        public int EnableCollector;
        
        public float collectorPositionOffset;
        public float collectorRadius;
        
        public Entity collectedItem;
        public float collectedItemPositionOffset;
    }

}