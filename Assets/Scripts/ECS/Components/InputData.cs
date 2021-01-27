﻿using com.TUDublin.VRContaminationSimulation.Input;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace com.TUDublin.VRContaminationSimulation.ECS.Components {

    [GenerateAuthoringComponent]
    public struct InputData : IComponentData {

        public ControllerType type;
        
        public bool GripTouch;
        public bool GripPress;
        public bool TriggerTouch;
        public bool TriggerPress;
        public bool PrimaryTouch;
        public bool PrimaryPress;
        public bool SecondaryTouch;
        public bool SecondaryPress;
        public bool JoystickTouch;
        public float2 Joystick;
        
    }

}