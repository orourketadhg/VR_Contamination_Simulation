// GENERATED AUTOMATICALLY FROM 'Assets/Input/VRControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VRControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VRControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRControls"",
    ""maps"": [
        {
            ""name"": ""XRRight"",
            ""id"": ""3c8fd46a-0dc1-42e7-b076-29d6379b444a"",
            ""actions"": [
                {
                    ""name"": ""GripTouch"",
                    ""type"": ""Value"",
                    ""id"": ""2208c8af-df2c-484f-9f33-7422a92eb60f"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripPress"",
                    ""type"": ""Button"",
                    ""id"": ""9ad36a68-dd80-4e97-bc7b-16758b465398"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTouch"",
                    ""type"": ""Value"",
                    ""id"": ""855d564f-2732-4841-9429-c5d5599d1a95"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerPress"",
                    ""type"": ""Button"",
                    ""id"": ""96263056-11a4-4e38-bad9-ae35ff0d4c1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""27b42b5b-e02a-4b66-a63b-9aaa6d7e08ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryPress"",
                    ""type"": ""Button"",
                    ""id"": ""92ebd2ba-9586-4c3c-b749-0bb6029cc134"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""995032b6-a141-4f0e-8fe1-1da4290021da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryPress"",
                    ""type"": ""Button"",
                    ""id"": ""c661fd39-7835-4b14-b9d7-e420b295bc3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoystickTouch"",
                    ""type"": ""Button"",
                    ""id"": ""2b5d784e-5f32-45c3-961c-158509f91298"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""eacea3c4-fedb-4ccc-9761-08ba6e7a4e53"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouthBreath"",
                    ""type"": ""Button"",
                    ""id"": ""c0239089-5457-41bb-8a9c-48616e05ee30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NoseBreath"",
                    ""type"": ""Button"",
                    ""id"": ""8376e6ea-12ef-46dc-84d9-130acc60aa8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""59c04a12-9582-4669-bfa4-277086ac15b2"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""GripPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fe18ebe-c918-457f-8355-46b6bb8cf597"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""TriggerPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d817c86-2866-4b9d-9545-b39aeacb52ea"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92605016-04d5-4580-9d27-3fae15573e62"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8c388e8-9181-4138-8c51-931fc1ba8ea0"",
                    ""path"": ""<XRController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f30590ce-e1e8-4f3a-b359-5c48be216995"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a51618d-b5b2-48c7-9926-0ef507fe3a3b"",
                    ""path"": ""<XRController>{RightHand}/primaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daf2528f-5ce4-42e7-96f3-3fddbd559d65"",
                    ""path"": ""<XRController>{RightHand}/secondaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a8cc10d-373d-405f-aaae-f3b699c7d170"",
                    ""path"": ""<XRController>{RightHand}/thumbstickTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""464f6409-9852-4545-be18-c8259e491047"",
                    ""path"": ""<XRController>{RightHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51f54382-9b3b-4faf-ac18-3ae771b250a5"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoseBreath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a19e742-f86c-4186-a9be-04d62880bd4e"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouthBreath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XRLeft"",
            ""id"": ""4038f130-7b63-408f-8bc4-1b309c58f744"",
            ""actions"": [
                {
                    ""name"": ""GripTouch"",
                    ""type"": ""Value"",
                    ""id"": ""d279b5bc-b51d-40ce-9204-08a9b9d7855b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripPress"",
                    ""type"": ""Button"",
                    ""id"": ""29b18b20-c062-4374-806c-e0e434fcf59b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTouch"",
                    ""type"": ""Value"",
                    ""id"": ""3a9f6cb7-b703-4756-9d02-11a2cfc90841"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerPress"",
                    ""type"": ""Button"",
                    ""id"": ""06b748bf-5b89-4adc-8717-20941c22b5a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""d9c9dbc3-3849-4d9f-a985-47e7d9989527"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryPress"",
                    ""type"": ""Button"",
                    ""id"": ""c047c9c4-fda5-4944-ae57-cb028ac351b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""7cd5c785-f540-4b2c-bcad-0023f393f081"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryPress"",
                    ""type"": ""Button"",
                    ""id"": ""131318dd-3899-4617-bcee-098bbeee6420"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoystickTouch"",
                    ""type"": ""Button"",
                    ""id"": ""39617e23-7f34-4030-834c-e63bf51215f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""42601efe-ee76-4997-ad97-878c546c53ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sneeze"",
                    ""type"": ""Button"",
                    ""id"": ""12d64471-3aa4-4811-9e75-f589becd159d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cough"",
                    ""type"": ""Button"",
                    ""id"": ""a6d1a456-bfeb-4856-99a8-e456da499e75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fef42440-7312-4c3c-bd85-80dd1cec111f"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""GripPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""844d8fb2-79b0-496b-a2ef-3ae4e835cbbf"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16da2993-4998-4458-804f-4ddd00c9f324"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""179e82a9-178a-46ce-a0e4-43d787dcc595"",
                    ""path"": ""<XRController>{LeftHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03104bf7-c85c-40d0-aaef-d447e23923be"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""TriggerPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b8a7cf4-17cc-44f9-9598-57a8b5983671"",
                    ""path"": ""<XRController>{LeftHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d04ee08-5aa8-4fca-8416-6bc2b8377890"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""469a5214-b200-47bd-a2bd-c3f0ec21c6d0"",
                    ""path"": ""<XRController>{LeftHand}/primaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cc28634-53cc-4c3f-b6b8-2c25d5f66db9"",
                    ""path"": ""<XRController>{LeftHand}/secondaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c9c3d64-1389-42bf-b2ac-b1c9647291fd"",
                    ""path"": ""<XRController>{LeftHand}/thumbstickTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33e886de-6548-4b14-b0d8-baa736dfad22"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sneeze"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae8d2e04-c4dc-4b1e-9480-0459af5c445f"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cough"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XRRight
        m_XRRight = asset.FindActionMap("XRRight", throwIfNotFound: true);
        m_XRRight_GripTouch = m_XRRight.FindAction("GripTouch", throwIfNotFound: true);
        m_XRRight_GripPress = m_XRRight.FindAction("GripPress", throwIfNotFound: true);
        m_XRRight_TriggerTouch = m_XRRight.FindAction("TriggerTouch", throwIfNotFound: true);
        m_XRRight_TriggerPress = m_XRRight.FindAction("TriggerPress", throwIfNotFound: true);
        m_XRRight_PrimaryTouch = m_XRRight.FindAction("PrimaryTouch", throwIfNotFound: true);
        m_XRRight_PrimaryPress = m_XRRight.FindAction("PrimaryPress", throwIfNotFound: true);
        m_XRRight_SecondaryTouch = m_XRRight.FindAction("SecondaryTouch", throwIfNotFound: true);
        m_XRRight_SecondaryPress = m_XRRight.FindAction("SecondaryPress", throwIfNotFound: true);
        m_XRRight_JoystickTouch = m_XRRight.FindAction("JoystickTouch", throwIfNotFound: true);
        m_XRRight_Joystick = m_XRRight.FindAction("Joystick", throwIfNotFound: true);
        m_XRRight_MouthBreath = m_XRRight.FindAction("MouthBreath", throwIfNotFound: true);
        m_XRRight_NoseBreath = m_XRRight.FindAction("NoseBreath", throwIfNotFound: true);
        // XRLeft
        m_XRLeft = asset.FindActionMap("XRLeft", throwIfNotFound: true);
        m_XRLeft_GripTouch = m_XRLeft.FindAction("GripTouch", throwIfNotFound: true);
        m_XRLeft_GripPress = m_XRLeft.FindAction("GripPress", throwIfNotFound: true);
        m_XRLeft_TriggerTouch = m_XRLeft.FindAction("TriggerTouch", throwIfNotFound: true);
        m_XRLeft_TriggerPress = m_XRLeft.FindAction("TriggerPress", throwIfNotFound: true);
        m_XRLeft_PrimaryTouch = m_XRLeft.FindAction("PrimaryTouch", throwIfNotFound: true);
        m_XRLeft_PrimaryPress = m_XRLeft.FindAction("PrimaryPress", throwIfNotFound: true);
        m_XRLeft_SecondaryTouch = m_XRLeft.FindAction("SecondaryTouch", throwIfNotFound: true);
        m_XRLeft_SecondaryPress = m_XRLeft.FindAction("SecondaryPress", throwIfNotFound: true);
        m_XRLeft_JoystickTouch = m_XRLeft.FindAction("JoystickTouch", throwIfNotFound: true);
        m_XRLeft_Joystick = m_XRLeft.FindAction("Joystick", throwIfNotFound: true);
        m_XRLeft_Sneeze = m_XRLeft.FindAction("Sneeze", throwIfNotFound: true);
        m_XRLeft_Cough = m_XRLeft.FindAction("Cough", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // XRRight
    private readonly InputActionMap m_XRRight;
    private IXRRightActions m_XRRightActionsCallbackInterface;
    private readonly InputAction m_XRRight_GripTouch;
    private readonly InputAction m_XRRight_GripPress;
    private readonly InputAction m_XRRight_TriggerTouch;
    private readonly InputAction m_XRRight_TriggerPress;
    private readonly InputAction m_XRRight_PrimaryTouch;
    private readonly InputAction m_XRRight_PrimaryPress;
    private readonly InputAction m_XRRight_SecondaryTouch;
    private readonly InputAction m_XRRight_SecondaryPress;
    private readonly InputAction m_XRRight_JoystickTouch;
    private readonly InputAction m_XRRight_Joystick;
    private readonly InputAction m_XRRight_MouthBreath;
    private readonly InputAction m_XRRight_NoseBreath;
    public struct XRRightActions
    {
        private @VRControls m_Wrapper;
        public XRRightActions(@VRControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @GripTouch => m_Wrapper.m_XRRight_GripTouch;
        public InputAction @GripPress => m_Wrapper.m_XRRight_GripPress;
        public InputAction @TriggerTouch => m_Wrapper.m_XRRight_TriggerTouch;
        public InputAction @TriggerPress => m_Wrapper.m_XRRight_TriggerPress;
        public InputAction @PrimaryTouch => m_Wrapper.m_XRRight_PrimaryTouch;
        public InputAction @PrimaryPress => m_Wrapper.m_XRRight_PrimaryPress;
        public InputAction @SecondaryTouch => m_Wrapper.m_XRRight_SecondaryTouch;
        public InputAction @SecondaryPress => m_Wrapper.m_XRRight_SecondaryPress;
        public InputAction @JoystickTouch => m_Wrapper.m_XRRight_JoystickTouch;
        public InputAction @Joystick => m_Wrapper.m_XRRight_Joystick;
        public InputAction @MouthBreath => m_Wrapper.m_XRRight_MouthBreath;
        public InputAction @NoseBreath => m_Wrapper.m_XRRight_NoseBreath;
        public InputActionMap Get() { return m_Wrapper.m_XRRight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRRightActions set) { return set.Get(); }
        public void SetCallbacks(IXRRightActions instance)
        {
            if (m_Wrapper.m_XRRightActionsCallbackInterface != null)
            {
                @GripTouch.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripTouch;
                @GripTouch.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripTouch;
                @GripTouch.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripTouch;
                @GripPress.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripPress;
                @GripPress.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripPress;
                @GripPress.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnGripPress;
                @TriggerTouch.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerTouch;
                @TriggerPress.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnTriggerPress;
                @PrimaryTouch.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryPress.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryPress;
                @PrimaryPress.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryPress;
                @PrimaryPress.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnPrimaryPress;
                @SecondaryTouch.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryPress.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryPress;
                @SecondaryPress.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryPress;
                @SecondaryPress.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnSecondaryPress;
                @JoystickTouch.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystickTouch;
                @JoystickTouch.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystickTouch;
                @JoystickTouch.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystickTouch;
                @Joystick.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystick;
                @Joystick.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystick;
                @Joystick.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnJoystick;
                @MouthBreath.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnMouthBreath;
                @MouthBreath.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnMouthBreath;
                @MouthBreath.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnMouthBreath;
                @NoseBreath.started -= m_Wrapper.m_XRRightActionsCallbackInterface.OnNoseBreath;
                @NoseBreath.performed -= m_Wrapper.m_XRRightActionsCallbackInterface.OnNoseBreath;
                @NoseBreath.canceled -= m_Wrapper.m_XRRightActionsCallbackInterface.OnNoseBreath;
            }
            m_Wrapper.m_XRRightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GripTouch.started += instance.OnGripTouch;
                @GripTouch.performed += instance.OnGripTouch;
                @GripTouch.canceled += instance.OnGripTouch;
                @GripPress.started += instance.OnGripPress;
                @GripPress.performed += instance.OnGripPress;
                @GripPress.canceled += instance.OnGripPress;
                @TriggerTouch.started += instance.OnTriggerTouch;
                @TriggerTouch.performed += instance.OnTriggerTouch;
                @TriggerTouch.canceled += instance.OnTriggerTouch;
                @TriggerPress.started += instance.OnTriggerPress;
                @TriggerPress.performed += instance.OnTriggerPress;
                @TriggerPress.canceled += instance.OnTriggerPress;
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @PrimaryPress.started += instance.OnPrimaryPress;
                @PrimaryPress.performed += instance.OnPrimaryPress;
                @PrimaryPress.canceled += instance.OnPrimaryPress;
                @SecondaryTouch.started += instance.OnSecondaryTouch;
                @SecondaryTouch.performed += instance.OnSecondaryTouch;
                @SecondaryTouch.canceled += instance.OnSecondaryTouch;
                @SecondaryPress.started += instance.OnSecondaryPress;
                @SecondaryPress.performed += instance.OnSecondaryPress;
                @SecondaryPress.canceled += instance.OnSecondaryPress;
                @JoystickTouch.started += instance.OnJoystickTouch;
                @JoystickTouch.performed += instance.OnJoystickTouch;
                @JoystickTouch.canceled += instance.OnJoystickTouch;
                @Joystick.started += instance.OnJoystick;
                @Joystick.performed += instance.OnJoystick;
                @Joystick.canceled += instance.OnJoystick;
                @MouthBreath.started += instance.OnMouthBreath;
                @MouthBreath.performed += instance.OnMouthBreath;
                @MouthBreath.canceled += instance.OnMouthBreath;
                @NoseBreath.started += instance.OnNoseBreath;
                @NoseBreath.performed += instance.OnNoseBreath;
                @NoseBreath.canceled += instance.OnNoseBreath;
            }
        }
    }
    public XRRightActions @XRRight => new XRRightActions(this);

    // XRLeft
    private readonly InputActionMap m_XRLeft;
    private IXRLeftActions m_XRLeftActionsCallbackInterface;
    private readonly InputAction m_XRLeft_GripTouch;
    private readonly InputAction m_XRLeft_GripPress;
    private readonly InputAction m_XRLeft_TriggerTouch;
    private readonly InputAction m_XRLeft_TriggerPress;
    private readonly InputAction m_XRLeft_PrimaryTouch;
    private readonly InputAction m_XRLeft_PrimaryPress;
    private readonly InputAction m_XRLeft_SecondaryTouch;
    private readonly InputAction m_XRLeft_SecondaryPress;
    private readonly InputAction m_XRLeft_JoystickTouch;
    private readonly InputAction m_XRLeft_Joystick;
    private readonly InputAction m_XRLeft_Sneeze;
    private readonly InputAction m_XRLeft_Cough;
    public struct XRLeftActions
    {
        private @VRControls m_Wrapper;
        public XRLeftActions(@VRControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @GripTouch => m_Wrapper.m_XRLeft_GripTouch;
        public InputAction @GripPress => m_Wrapper.m_XRLeft_GripPress;
        public InputAction @TriggerTouch => m_Wrapper.m_XRLeft_TriggerTouch;
        public InputAction @TriggerPress => m_Wrapper.m_XRLeft_TriggerPress;
        public InputAction @PrimaryTouch => m_Wrapper.m_XRLeft_PrimaryTouch;
        public InputAction @PrimaryPress => m_Wrapper.m_XRLeft_PrimaryPress;
        public InputAction @SecondaryTouch => m_Wrapper.m_XRLeft_SecondaryTouch;
        public InputAction @SecondaryPress => m_Wrapper.m_XRLeft_SecondaryPress;
        public InputAction @JoystickTouch => m_Wrapper.m_XRLeft_JoystickTouch;
        public InputAction @Joystick => m_Wrapper.m_XRLeft_Joystick;
        public InputAction @Sneeze => m_Wrapper.m_XRLeft_Sneeze;
        public InputAction @Cough => m_Wrapper.m_XRLeft_Cough;
        public InputActionMap Get() { return m_Wrapper.m_XRLeft; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRLeftActions set) { return set.Get(); }
        public void SetCallbacks(IXRLeftActions instance)
        {
            if (m_Wrapper.m_XRLeftActionsCallbackInterface != null)
            {
                @GripTouch.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripTouch;
                @GripTouch.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripTouch;
                @GripTouch.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripTouch;
                @GripPress.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripPress;
                @GripPress.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripPress;
                @GripPress.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnGripPress;
                @TriggerTouch.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerTouch;
                @TriggerPress.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnTriggerPress;
                @PrimaryTouch.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryPress.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryPress;
                @PrimaryPress.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryPress;
                @PrimaryPress.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnPrimaryPress;
                @SecondaryTouch.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryPress.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryPress;
                @SecondaryPress.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryPress;
                @SecondaryPress.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSecondaryPress;
                @JoystickTouch.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystickTouch;
                @JoystickTouch.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystickTouch;
                @JoystickTouch.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystickTouch;
                @Joystick.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystick;
                @Joystick.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystick;
                @Joystick.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnJoystick;
                @Sneeze.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSneeze;
                @Sneeze.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSneeze;
                @Sneeze.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnSneeze;
                @Cough.started -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnCough;
                @Cough.performed -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnCough;
                @Cough.canceled -= m_Wrapper.m_XRLeftActionsCallbackInterface.OnCough;
            }
            m_Wrapper.m_XRLeftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GripTouch.started += instance.OnGripTouch;
                @GripTouch.performed += instance.OnGripTouch;
                @GripTouch.canceled += instance.OnGripTouch;
                @GripPress.started += instance.OnGripPress;
                @GripPress.performed += instance.OnGripPress;
                @GripPress.canceled += instance.OnGripPress;
                @TriggerTouch.started += instance.OnTriggerTouch;
                @TriggerTouch.performed += instance.OnTriggerTouch;
                @TriggerTouch.canceled += instance.OnTriggerTouch;
                @TriggerPress.started += instance.OnTriggerPress;
                @TriggerPress.performed += instance.OnTriggerPress;
                @TriggerPress.canceled += instance.OnTriggerPress;
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @PrimaryPress.started += instance.OnPrimaryPress;
                @PrimaryPress.performed += instance.OnPrimaryPress;
                @PrimaryPress.canceled += instance.OnPrimaryPress;
                @SecondaryTouch.started += instance.OnSecondaryTouch;
                @SecondaryTouch.performed += instance.OnSecondaryTouch;
                @SecondaryTouch.canceled += instance.OnSecondaryTouch;
                @SecondaryPress.started += instance.OnSecondaryPress;
                @SecondaryPress.performed += instance.OnSecondaryPress;
                @SecondaryPress.canceled += instance.OnSecondaryPress;
                @JoystickTouch.started += instance.OnJoystickTouch;
                @JoystickTouch.performed += instance.OnJoystickTouch;
                @JoystickTouch.canceled += instance.OnJoystickTouch;
                @Joystick.started += instance.OnJoystick;
                @Joystick.performed += instance.OnJoystick;
                @Joystick.canceled += instance.OnJoystick;
                @Sneeze.started += instance.OnSneeze;
                @Sneeze.performed += instance.OnSneeze;
                @Sneeze.canceled += instance.OnSneeze;
                @Cough.started += instance.OnCough;
                @Cough.performed += instance.OnCough;
                @Cough.canceled += instance.OnCough;
            }
        }
    }
    public XRLeftActions @XRLeft => new XRLeftActions(this);
    public interface IXRRightActions
    {
        void OnGripTouch(InputAction.CallbackContext context);
        void OnGripPress(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
        void OnTriggerPress(InputAction.CallbackContext context);
        void OnPrimaryTouch(InputAction.CallbackContext context);
        void OnPrimaryPress(InputAction.CallbackContext context);
        void OnSecondaryTouch(InputAction.CallbackContext context);
        void OnSecondaryPress(InputAction.CallbackContext context);
        void OnJoystickTouch(InputAction.CallbackContext context);
        void OnJoystick(InputAction.CallbackContext context);
        void OnMouthBreath(InputAction.CallbackContext context);
        void OnNoseBreath(InputAction.CallbackContext context);
    }
    public interface IXRLeftActions
    {
        void OnGripTouch(InputAction.CallbackContext context);
        void OnGripPress(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
        void OnTriggerPress(InputAction.CallbackContext context);
        void OnPrimaryTouch(InputAction.CallbackContext context);
        void OnPrimaryPress(InputAction.CallbackContext context);
        void OnSecondaryTouch(InputAction.CallbackContext context);
        void OnSecondaryPress(InputAction.CallbackContext context);
        void OnJoystickTouch(InputAction.CallbackContext context);
        void OnJoystick(InputAction.CallbackContext context);
        void OnSneeze(InputAction.CallbackContext context);
        void OnCough(InputAction.CallbackContext context);
    }
}
