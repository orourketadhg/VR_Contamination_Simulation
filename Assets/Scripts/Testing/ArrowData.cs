using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace com.TUDublin.VRContaminationSimulation
{
    [GenerateAuthoringComponent]
    public struct ArrowData : IComponentData {
        public Entity joint;
    }
}