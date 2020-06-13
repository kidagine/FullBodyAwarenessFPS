// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/DebugInputs/DebugInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DebugInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugInputActions"",
    ""maps"": [
        {
            ""name"": ""DebugControls"",
            ""id"": ""81cae4ab-a618-4a10-a1ea-f2025f855f68"",
            ""actions"": [
                {
                    ""name"": ""OpenDebug"",
                    ""type"": ""Button"",
                    ""id"": ""e7a3b25f-f3a4-4f2e-95e6-912f3e96977a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""SelectDpadDown"",
                    ""id"": ""0cccb8ca-3f07-4141-a014-1818e0d0fd37"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""20229424-297a-4fa2-be94-4fedf94353c1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""fb7433ab-9e9b-45be-834d-76638d4803a5"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""QV"",
                    ""id"": ""737d02ff-2daa-4bec-8e16-7982106d1601"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""22f76c8f-fc69-46b7-9632-cbf66a4979d4"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""2853cf48-317e-4429-8cd9-d12fc76bda06"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""OpenDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        // DebugControls
        m_DebugControls = asset.FindActionMap("DebugControls", throwIfNotFound: true);
        m_DebugControls_OpenDebug = m_DebugControls.FindAction("OpenDebug", throwIfNotFound: true);
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

    // DebugControls
    private readonly InputActionMap m_DebugControls;
    private IDebugControlsActions m_DebugControlsActionsCallbackInterface;
    private readonly InputAction m_DebugControls_OpenDebug;
    public struct DebugControlsActions
    {
        private @DebugInputActions m_Wrapper;
        public DebugControlsActions(@DebugInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenDebug => m_Wrapper.m_DebugControls_OpenDebug;
        public InputActionMap Get() { return m_Wrapper.m_DebugControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugControlsActions instance)
        {
            if (m_Wrapper.m_DebugControlsActionsCallbackInterface != null)
            {
                @OpenDebug.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnOpenDebug;
                @OpenDebug.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnOpenDebug;
                @OpenDebug.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnOpenDebug;
            }
            m_Wrapper.m_DebugControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenDebug.started += instance.OnOpenDebug;
                @OpenDebug.performed += instance.OnOpenDebug;
                @OpenDebug.canceled += instance.OnOpenDebug;
            }
        }
    }
    public DebugControlsActions @DebugControls => new DebugControlsActions(this);
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
    public interface IDebugControlsActions
    {
        void OnOpenDebug(InputAction.CallbackContext context);
    }
}
