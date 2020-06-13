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
            ""name"": ""DebugDefaultControls"",
            ""id"": ""60ae2455-df20-415a-86f7-84f1433ea869"",
            ""actions"": [
                {
                    ""name"": ""CloseDebug"",
                    ""type"": ""Button"",
                    ""id"": ""ef7c90b7-bb0c-4596-b1de-d3d9d9826fdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""369eb77e-2968-4f0a-8e17-d4204d6ff1d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenDebugCamera"",
                    ""type"": ""Button"",
                    ""id"": ""da8e24f3-a6bd-4891-98fc-8af86e03de33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartScene"",
                    ""type"": ""Button"",
                    ""id"": ""ca00514c-c646-4588-b979-708ed73286de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextOption"",
                    ""type"": ""Button"",
                    ""id"": ""b1f8f960-3a25-4deb-8d56-b666c3ead056"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlowdownTime"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e10b89c3-9eea-4494-835f-cc6f1a568147"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLights"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a3e22625-b74f-4028-8f6e-c51c148c1e7b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SetLights"",
                    ""type"": ""Button"",
                    ""id"": ""d5194fb2-8c18-4a47-a2d6-b2f8fb7f78f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b2667712-e3df-4cca-9996-6d86f383f1ea"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CloseDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0c58e1f-6f57-4138-9b1e-f96e565aea52"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CloseDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1191830-2eae-484b-a5ef-3cc942316114"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1b740d0-ab6a-4571-ae80-f83e360e5cda"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""569eca1c-4880-4472-a84a-9403b2f8b3f0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f034f4-4ec7-4124-bd81-9a295ec032ce"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2685320-79b5-4dfd-b6e3-1f7082057c42"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NextOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8f483b7-813e-4d0a-9234-f8689da1cc40"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""NextOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cde3b7b-b878-4964-ae00-7a903ab81b31"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""41142baf-1ee7-40dd-a3a9-763399d8e86e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6aa83e00-8bfa-4a95-b443-5b1d0b10d5f1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c572fb4-3856-4235-b961-025bb14f3fe5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""471d29cc-48ac-4b22-b045-61cfa86db79c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""e4a155a3-0129-445a-b20e-e7bb0a3b2394"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLights"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55374868-cbb5-485f-8495-b5f306ccba01"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1f29ec0-95a2-4887-a7ad-90360fdb4c19"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd9625e3-1605-4f11-8e64-f53faf9ea002"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SetLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""286d1a6d-91db-4131-82af-70d9dbf4548e"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SetLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""265ce74d-25e7-44e8-b8fb-698144458295"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""OpenDebugCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2274c2be-9956-4657-996c-b896e949983f"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""OpenDebugCamera"",
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
        // DebugDefaultControls
        m_DebugDefaultControls = asset.FindActionMap("DebugDefaultControls", throwIfNotFound: true);
        m_DebugDefaultControls_CloseDebug = m_DebugDefaultControls.FindAction("CloseDebug", throwIfNotFound: true);
        m_DebugDefaultControls_Reset = m_DebugDefaultControls.FindAction("Reset", throwIfNotFound: true);
        m_DebugDefaultControls_OpenDebugCamera = m_DebugDefaultControls.FindAction("OpenDebugCamera", throwIfNotFound: true);
        m_DebugDefaultControls_RestartScene = m_DebugDefaultControls.FindAction("RestartScene", throwIfNotFound: true);
        m_DebugDefaultControls_NextOption = m_DebugDefaultControls.FindAction("NextOption", throwIfNotFound: true);
        m_DebugDefaultControls_SlowdownTime = m_DebugDefaultControls.FindAction("SlowdownTime", throwIfNotFound: true);
        m_DebugDefaultControls_MoveLights = m_DebugDefaultControls.FindAction("MoveLights", throwIfNotFound: true);
        m_DebugDefaultControls_SetLights = m_DebugDefaultControls.FindAction("SetLights", throwIfNotFound: true);
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

    // DebugDefaultControls
    private readonly InputActionMap m_DebugDefaultControls;
    private IDebugDefaultControlsActions m_DebugDefaultControlsActionsCallbackInterface;
    private readonly InputAction m_DebugDefaultControls_CloseDebug;
    private readonly InputAction m_DebugDefaultControls_Reset;
    private readonly InputAction m_DebugDefaultControls_OpenDebugCamera;
    private readonly InputAction m_DebugDefaultControls_RestartScene;
    private readonly InputAction m_DebugDefaultControls_NextOption;
    private readonly InputAction m_DebugDefaultControls_SlowdownTime;
    private readonly InputAction m_DebugDefaultControls_MoveLights;
    private readonly InputAction m_DebugDefaultControls_SetLights;
    public struct DebugDefaultControlsActions
    {
        private @DebugDefaultInputActions m_Wrapper;
        public DebugDefaultControlsActions(@DebugDefaultInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseDebug => m_Wrapper.m_DebugDefaultControls_CloseDebug;
        public InputAction @Reset => m_Wrapper.m_DebugDefaultControls_Reset;
        public InputAction @OpenDebugCamera => m_Wrapper.m_DebugDefaultControls_OpenDebugCamera;
        public InputAction @RestartScene => m_Wrapper.m_DebugDefaultControls_RestartScene;
        public InputAction @NextOption => m_Wrapper.m_DebugDefaultControls_NextOption;
        public InputAction @SlowdownTime => m_Wrapper.m_DebugDefaultControls_SlowdownTime;
        public InputAction @MoveLights => m_Wrapper.m_DebugDefaultControls_MoveLights;
        public InputAction @SetLights => m_Wrapper.m_DebugDefaultControls_SetLights;
        public InputActionMap Get() { return m_Wrapper.m_DebugDefaultControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugDefaultControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugDefaultControlsActions instance)
        {
            if (m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface != null)
            {
                @CloseDebug.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnCloseDebug;
                @CloseDebug.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnCloseDebug;
                @CloseDebug.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnCloseDebug;
                @Reset.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnReset;
                @OpenDebugCamera.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnOpenDebugCamera;
                @OpenDebugCamera.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnOpenDebugCamera;
                @OpenDebugCamera.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnOpenDebugCamera;
                @RestartScene.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnRestartScene;
                @RestartScene.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnRestartScene;
                @RestartScene.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnRestartScene;
                @NextOption.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnNextOption;
                @NextOption.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnNextOption;
                @NextOption.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnNextOption;
                @SlowdownTime.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSlowdownTime;
                @SlowdownTime.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSlowdownTime;
                @SlowdownTime.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSlowdownTime;
                @MoveLights.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnMoveLights;
                @MoveLights.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnMoveLights;
                @MoveLights.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnMoveLights;
                @SetLights.started -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSetLights;
                @SetLights.performed -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSetLights;
                @SetLights.canceled -= m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface.OnSetLights;
            }
            m_Wrapper.m_DebugDefaultControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseDebug.started += instance.OnCloseDebug;
                @CloseDebug.performed += instance.OnCloseDebug;
                @CloseDebug.canceled += instance.OnCloseDebug;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @OpenDebugCamera.started += instance.OnOpenDebugCamera;
                @OpenDebugCamera.performed += instance.OnOpenDebugCamera;
                @OpenDebugCamera.canceled += instance.OnOpenDebugCamera;
                @RestartScene.started += instance.OnRestartScene;
                @RestartScene.performed += instance.OnRestartScene;
                @RestartScene.canceled += instance.OnRestartScene;
                @NextOption.started += instance.OnNextOption;
                @NextOption.performed += instance.OnNextOption;
                @NextOption.canceled += instance.OnNextOption;
                @SlowdownTime.started += instance.OnSlowdownTime;
                @SlowdownTime.performed += instance.OnSlowdownTime;
                @SlowdownTime.canceled += instance.OnSlowdownTime;
                @MoveLights.started += instance.OnMoveLights;
                @MoveLights.performed += instance.OnMoveLights;
                @MoveLights.canceled += instance.OnMoveLights;
                @SetLights.started += instance.OnSetLights;
                @SetLights.performed += instance.OnSetLights;
                @SetLights.canceled += instance.OnSetLights;
            }
        }
    }
    public DebugDefaultControlsActions @DebugDefaultControls => new DebugDefaultControlsActions(this);
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
    public interface IDebugDefaultControlsActions
    {
        void OnCloseDebug(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnOpenDebugCamera(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnNextOption(InputAction.CallbackContext context);
        void OnSlowdownTime(InputAction.CallbackContext context);
        void OnMoveLights(InputAction.CallbackContext context);
        void OnSetLights(InputAction.CallbackContext context);
    }
}
