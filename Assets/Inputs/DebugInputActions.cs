// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/DebugInputActions.inputactions'

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
                    ""name"": ""SetDebug"",
                    ""type"": ""Button"",
                    ""id"": ""e9dbc2d6-c80a-4cdd-af92-f3500435e6f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlowdownTime"",
                    ""type"": ""Button"",
                    ""id"": ""b6d12703-47b0-4d10-b602-01f550ad61fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartScene"",
                    ""type"": ""Button"",
                    ""id"": ""83efc09d-8408-4416-b3ad-91f1dc79d81c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugCamera"",
                    ""type"": ""Button"",
                    ""id"": ""5d733628-ad87-444a-9a92-489cb145e895"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""12f0e6c9-93cf-482c-b19f-9c122c60cf43"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1dec75a7-7435-4da9-b76f-97b14482917d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""107dcf2c-b2cd-4a20-94e6-dd1ce2a5089f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bffdac99-a0ff-423a-9196-a69ae35571f9"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DebugControls
        m_DebugControls = asset.FindActionMap("DebugControls", throwIfNotFound: true);
        m_DebugControls_SetDebug = m_DebugControls.FindAction("SetDebug", throwIfNotFound: true);
        m_DebugControls_SlowdownTime = m_DebugControls.FindAction("SlowdownTime", throwIfNotFound: true);
        m_DebugControls_RestartScene = m_DebugControls.FindAction("RestartScene", throwIfNotFound: true);
        m_DebugControls_DebugCamera = m_DebugControls.FindAction("DebugCamera", throwIfNotFound: true);
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
    private readonly InputAction m_DebugControls_SetDebug;
    private readonly InputAction m_DebugControls_SlowdownTime;
    private readonly InputAction m_DebugControls_RestartScene;
    private readonly InputAction m_DebugControls_DebugCamera;
    public struct DebugControlsActions
    {
        private @DebugInputActions m_Wrapper;
        public DebugControlsActions(@DebugInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetDebug => m_Wrapper.m_DebugControls_SetDebug;
        public InputAction @SlowdownTime => m_Wrapper.m_DebugControls_SlowdownTime;
        public InputAction @RestartScene => m_Wrapper.m_DebugControls_RestartScene;
        public InputAction @DebugCamera => m_Wrapper.m_DebugControls_DebugCamera;
        public InputActionMap Get() { return m_Wrapper.m_DebugControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugControlsActions instance)
        {
            if (m_Wrapper.m_DebugControlsActionsCallbackInterface != null)
            {
                @SetDebug.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSetDebug;
                @SetDebug.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSetDebug;
                @SetDebug.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSetDebug;
                @SlowdownTime.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSlowdownTime;
                @SlowdownTime.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSlowdownTime;
                @SlowdownTime.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSlowdownTime;
                @RestartScene.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnRestartScene;
                @RestartScene.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnRestartScene;
                @RestartScene.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnRestartScene;
                @DebugCamera.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnDebugCamera;
                @DebugCamera.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnDebugCamera;
                @DebugCamera.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnDebugCamera;
            }
            m_Wrapper.m_DebugControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SetDebug.started += instance.OnSetDebug;
                @SetDebug.performed += instance.OnSetDebug;
                @SetDebug.canceled += instance.OnSetDebug;
                @SlowdownTime.started += instance.OnSlowdownTime;
                @SlowdownTime.performed += instance.OnSlowdownTime;
                @SlowdownTime.canceled += instance.OnSlowdownTime;
                @RestartScene.started += instance.OnRestartScene;
                @RestartScene.performed += instance.OnRestartScene;
                @RestartScene.canceled += instance.OnRestartScene;
                @DebugCamera.started += instance.OnDebugCamera;
                @DebugCamera.performed += instance.OnDebugCamera;
                @DebugCamera.canceled += instance.OnDebugCamera;
            }
        }
    }
    public DebugControlsActions @DebugControls => new DebugControlsActions(this);
    public interface IDebugControlsActions
    {
        void OnSetDebug(InputAction.CallbackContext context);
        void OnSlowdownTime(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnDebugCamera(InputAction.CallbackContext context);
    }
}
