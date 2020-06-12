// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/DebugInputs/DebugDefaultInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DebugDefaultInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugDefaultInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugDefaultInputActions"",
    ""maps"": [
        {
            ""name"": ""DebugCameraControls"",
            ""id"": ""60ae2455-df20-415a-86f7-84f1433ea869"",
            ""actions"": [
                {
                    ""name"": ""SetCamera"",
                    ""type"": ""Button"",
                    ""id"": ""ef7c90b7-bb0c-4596-b1de-d3d9d9826fdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""e759f635-38b3-49a4-81ad-bab328ad22ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b2667712-e3df-4cca-9996-6d86f383f1ea"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SetCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48c5543c-61e0-4148-808d-9410df40bc1a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // DebugCameraControls
        m_DebugCameraControls = asset.FindActionMap("DebugCameraControls", throwIfNotFound: true);
        m_DebugCameraControls_SetCamera = m_DebugCameraControls.FindAction("SetCamera", throwIfNotFound: true);
        m_DebugCameraControls_Newaction = m_DebugCameraControls.FindAction("New action", throwIfNotFound: true);
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

    // DebugCameraControls
    private readonly InputActionMap m_DebugCameraControls;
    private IDebugCameraControlsActions m_DebugCameraControlsActionsCallbackInterface;
    private readonly InputAction m_DebugCameraControls_SetCamera;
    private readonly InputAction m_DebugCameraControls_Newaction;
    public struct DebugCameraControlsActions
    {
        private @DebugDefaultInputActions m_Wrapper;
        public DebugCameraControlsActions(@DebugDefaultInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetCamera => m_Wrapper.m_DebugCameraControls_SetCamera;
        public InputAction @Newaction => m_Wrapper.m_DebugCameraControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_DebugCameraControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugCameraControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugCameraControlsActions instance)
        {
            if (m_Wrapper.m_DebugCameraControlsActionsCallbackInterface != null)
            {
                @SetCamera.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnSetCamera;
                @SetCamera.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnSetCamera;
                @SetCamera.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnSetCamera;
                @Newaction.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_DebugCameraControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SetCamera.started += instance.OnSetCamera;
                @SetCamera.performed += instance.OnSetCamera;
                @SetCamera.canceled += instance.OnSetCamera;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public DebugCameraControlsActions @DebugCameraControls => new DebugCameraControlsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IDebugCameraControlsActions
    {
        void OnSetCamera(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
}
