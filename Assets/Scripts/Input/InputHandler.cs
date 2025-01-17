﻿using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = Unity.Mathematics.Random;

namespace com.TUDublin.VRContaminationSimulation.Input {

    /**
     * Input Handler for MonoBehaviour Scripts and GameObjects
     */
    public class InputHandler : MonoBehaviour, VRControls.IXRRightActions, VRControls.IXRLeftActions {
     
        private VRControls _input;

        [Header("Right XR Controller")]
        public bool rightGripPress;
        public bool rightTriggerTouch;
        public bool rightTriggerPress;
        public bool rightPrimaryTouch;
        public bool rightPrimaryPress;
        public bool rightSecondaryTouch;
        public bool rightSecondaryPress;
        public bool rightJoystickTouch;
        public bool rightJoystickPress;
        public Vector2 rightJoystick;
        
        [Header("Left XR Controller")]
        public bool leftGripPress;
        public bool leftTriggerTouch;
        public bool leftTriggerPress;
        public bool leftPrimaryTouch;
        public bool leftPrimaryPress;
        public bool leftSecondaryTouch;
        public bool leftSecondaryPress;
        public bool leftJoystickTouch;
        public bool leftJoystickPress;
        public Vector2 leftJoystick;
        
        private void Awake() { 
            // set input callback to this
            _input = new VRControls();
            _input.XRLeft.SetCallbacks(this);
            _input.XRRight.SetCallbacks(this);
        }
        
        /**
         * Enable Inputs
         */
        private void OnEnable() => _input.Enable();
        /**
         * Disable Inputs
         */
        private void OnDisable() => _input.Disable();

        #region Right XR Controller
        
        /**
         * Capture Right XR controller inputs 
         */
        void VRControls.IXRRightActions.OnGripPress(InputAction.CallbackContext context) => rightGripPress = context.performed;
        void VRControls.IXRRightActions.OnTriggerTouch(InputAction.CallbackContext context) => rightTriggerTouch = context.performed;
        void VRControls.IXRRightActions.OnTriggerPress(InputAction.CallbackContext context) => rightTriggerPress = context.performed;
        void VRControls.IXRRightActions.OnPrimaryTouch(InputAction.CallbackContext context) => rightPrimaryTouch = context.performed;
        void VRControls.IXRRightActions.OnPrimaryPress(InputAction.CallbackContext context) => rightPrimaryPress = context.performed;
        void VRControls.IXRRightActions.OnSecondaryTouch(InputAction.CallbackContext context) => rightSecondaryTouch = context.performed;
        void VRControls.IXRRightActions.OnSecondaryPress(InputAction.CallbackContext context) => rightSecondaryPress = context.performed;
        void VRControls.IXRRightActions.OnJoystickTouch(InputAction.CallbackContext context) => rightJoystickTouch = context.performed;
        void VRControls.IXRRightActions.OnJoystickPress(InputAction.CallbackContext context) => rightJoystickPress = context.performed;
        void VRControls.IXRRightActions.OnJoystick(InputAction.CallbackContext context) => rightJoystick = context.ReadValue<Vector2>();

        #endregion
        
        #region Left XR Controller
        
        /**
         * Capture Left XR controller inputs 
         */
        void VRControls.IXRLeftActions.OnGripPress(InputAction.CallbackContext context) => leftGripPress = context.performed;
        void VRControls.IXRLeftActions.OnTriggerTouch(InputAction.CallbackContext context) => leftTriggerTouch = context.performed;
        void VRControls.IXRLeftActions.OnTriggerPress(InputAction.CallbackContext context) => leftTriggerPress = context.performed;
        void VRControls.IXRLeftActions.OnPrimaryTouch(InputAction.CallbackContext context) => leftPrimaryTouch = context.performed;
        void VRControls.IXRLeftActions.OnPrimaryPress(InputAction.CallbackContext context) => leftPrimaryPress = context.performed;
        void VRControls.IXRLeftActions.OnSecondaryTouch(InputAction.CallbackContext context) => leftSecondaryTouch = context.performed;
        void VRControls.IXRLeftActions.OnSecondaryPress(InputAction.CallbackContext context) => leftSecondaryPress = context.performed;
        void VRControls.IXRLeftActions.OnJoystickTouch(InputAction.CallbackContext context) => leftJoystickTouch = context.performed;
        void VRControls.IXRLeftActions.OnJoystickPress(InputAction.CallbackContext context) => leftJoystickPress = context.performed;
        void VRControls.IXRLeftActions.OnJoystick(InputAction.CallbackContext context) => leftJoystick = context.ReadValue<Vector2>();

        #endregion
        
    }

}