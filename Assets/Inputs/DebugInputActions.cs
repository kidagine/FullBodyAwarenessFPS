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
                    ""type"": ""PassThrough"",
                    ""id"": ""b6d12703-47b0-4d10-b602-01f550ad61fa"",
                    ""expectedControlType"": ""Vector2"",
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
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e7ac9c61-6995-47a1-905d-49fad7ea35db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""82b0d4b3-48a9-4e43-bbc3-148eb19f8335"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=0.75,y=0.75)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpeedMovement"",
                    ""type"": ""Button"",
                    ""id"": ""bb3a437d-181e-451c-b0eb-95950ba45e5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=0.75,y=0.75),StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextOption"",
                    ""type"": ""Button"",
                    ""id"": ""2588efa7-e73b-4951-b816-0ce07423cf1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=0.75,y=0.75),StickDeadzone"",
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
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SlowdownTime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0204b624-774e-4ec6-976c-cb0edc577b4e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c31538e5-3217-4995-90e0-d113c716fa48"",
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
                    ""id"": ""107dcf2c-b2cd-4a20-94e6-dd1ce2a5089f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e7ab92b-7660-4a40-81be-421f77bd92b3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SetDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab1a5e52-61d9-4fe4-9208-6244e4a7cf59"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SetDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9989887-412d-46c5-8583-477d02b618e6"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d45c17b-6b68-4a32-bf5e-a40d0dd42cdd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.15,y=0.15)"",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f03052de-cff9-4456-9e4e-29fa1781276e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d9789880-568b-4405-8ec6-68db36c5c41a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a9dc0b37-aadf-46a3-bd2f-089c6a62a89a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""752061a8-20bd-4ba7-8020-b155aa457a36"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""32b87fd1-4612-4908-a693-918e371c090f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""403c22c7-3e94-4e87-bd0b-29dcea4a7772"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""618a44e6-0f10-41ae-9d8f-5377e5c98b3b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0ad05870-23c7-47ac-8700-ccd2d2c7d9d4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94ffee7a-db0d-4824-b533-92f997fd445b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bbdbf462-2fc0-4cb3-a4c7-9a6e519461e8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a396046-9c7b-49dc-9b77-12f93a6e39cf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""068e30aa-ee82-47ce-a7fc-59f2fc384c2e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpeedMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b58795ee-5560-4873-9944-256f88481e82"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SpeedMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76230a8c-24d9-49cd-a281-7dfc4d37d676"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""NextOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ff285e1-0a10-4ea0-87fc-83fd5170075d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NextOption"",
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
        // DebugControls
        m_DebugControls = asset.FindActionMap("DebugControls", throwIfNotFound: true);
        m_DebugControls_SetDebug = m_DebugControls.FindAction("SetDebug", throwIfNotFound: true);
        m_DebugControls_SlowdownTime = m_DebugControls.FindAction("SlowdownTime", throwIfNotFound: true);
        m_DebugControls_RestartScene = m_DebugControls.FindAction("RestartScene", throwIfNotFound: true);
        m_DebugControls_DebugCamera = m_DebugControls.FindAction("DebugCamera", throwIfNotFound: true);
        m_DebugControls_CameraMovement = m_DebugControls.FindAction("CameraMovement", throwIfNotFound: true);
        m_DebugControls_CameraRotation = m_DebugControls.FindAction("CameraRotation", throwIfNotFound: true);
        m_DebugControls_SpeedMovement = m_DebugControls.FindAction("SpeedMovement", throwIfNotFound: true);
        m_DebugControls_NextOption = m_DebugControls.FindAction("NextOption", throwIfNotFound: true);
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
    private readonly InputAction m_DebugControls_CameraMovement;
    private readonly InputAction m_DebugControls_CameraRotation;
    private readonly InputAction m_DebugControls_SpeedMovement;
    private readonly InputAction m_DebugControls_NextOption;
    public struct DebugControlsActions
    {
        private @DebugInputActions m_Wrapper;
        public DebugControlsActions(@DebugInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetDebug => m_Wrapper.m_DebugControls_SetDebug;
        public InputAction @SlowdownTime => m_Wrapper.m_DebugControls_SlowdownTime;
        public InputAction @RestartScene => m_Wrapper.m_DebugControls_RestartScene;
        public InputAction @DebugCamera => m_Wrapper.m_DebugControls_DebugCamera;
        public InputAction @CameraMovement => m_Wrapper.m_DebugControls_CameraMovement;
        public InputAction @CameraRotation => m_Wrapper.m_DebugControls_CameraRotation;
        public InputAction @SpeedMovement => m_Wrapper.m_DebugControls_SpeedMovement;
        public InputAction @NextOption => m_Wrapper.m_DebugControls_NextOption;
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
                @CameraMovement.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraMovement;
                @CameraRotation.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnCameraRotation;
                @SpeedMovement.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSpeedMovement;
                @SpeedMovement.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSpeedMovement;
                @SpeedMovement.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnSpeedMovement;
                @NextOption.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnNextOption;
                @NextOption.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnNextOption;
                @NextOption.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnNextOption;
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
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @SpeedMovement.started += instance.OnSpeedMovement;
                @SpeedMovement.performed += instance.OnSpeedMovement;
                @SpeedMovement.canceled += instance.OnSpeedMovement;
                @NextOption.started += instance.OnNextOption;
                @NextOption.performed += instance.OnNextOption;
                @NextOption.canceled += instance.OnNextOption;
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
        void OnSetDebug(InputAction.CallbackContext context);
        void OnSlowdownTime(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnDebugCamera(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnSpeedMovement(InputAction.CallbackContext context);
        void OnNextOption(InputAction.CallbackContext context);
    }
}
