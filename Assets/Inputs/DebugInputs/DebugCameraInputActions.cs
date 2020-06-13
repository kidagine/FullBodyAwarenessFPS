// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/DebugInputs/DebugCameraInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DebugCameraInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DebugCameraInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugCameraInputActions"",
    ""maps"": [
        {
            ""name"": ""DebugCameraControls"",
            ""id"": ""60ae2455-df20-415a-86f7-84f1433ea869"",
            ""actions"": [
                {
                    ""name"": ""CloseDebugCamera"",
                    ""type"": ""Button"",
                    ""id"": ""ef7c90b7-bb0c-4596-b1de-d3d9d9826fdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugCameraMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""88c322fc-e59d-404c-92b4-97e9774395ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugCameraRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a209683-0fc2-426a-99c9-71296df2d4f9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugCameraSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""a8b02d04-b435-4bac-acfe-c2de485dbd65"",
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
                    ""action"": ""CloseDebugCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""036cb1af-8f8c-44e9-8b60-5b0e185bdb08"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CloseDebugCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87841708-0937-4880-a3b7-905a372eb935"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2dc31cbc-e59c-45b1-a2b9-c1d6e207689f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""608ae8f2-9ab1-4553-a546-882d4b01e7a2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""91a395d3-1f53-4241-80d3-07964f45a1c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d4937415-44b3-407c-8cb5-396e64fe6145"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f2526661-ebbe-4c98-892b-aebd61d612f4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c6fe3434-a564-4894-8621-fc0554c76c18"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,ScaleVector2(x=0.75,y=0.75)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DebugCameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3166bc65-756f-4038-8d4c-1fc28a4c460d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d2493a7-d103-4c15-8398-78e21946a3b1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DebugCameraSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ed9acc6-dcf3-45a3-894f-6635c8cbfb8b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""DebugCameraSpeed"",
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
        m_DebugCameraControls_CloseDebugCamera = m_DebugCameraControls.FindAction("CloseDebugCamera", throwIfNotFound: true);
        m_DebugCameraControls_DebugCameraMovement = m_DebugCameraControls.FindAction("DebugCameraMovement", throwIfNotFound: true);
        m_DebugCameraControls_DebugCameraRotation = m_DebugCameraControls.FindAction("DebugCameraRotation", throwIfNotFound: true);
        m_DebugCameraControls_DebugCameraSpeed = m_DebugCameraControls.FindAction("DebugCameraSpeed", throwIfNotFound: true);
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
    private readonly InputAction m_DebugCameraControls_CloseDebugCamera;
    private readonly InputAction m_DebugCameraControls_DebugCameraMovement;
    private readonly InputAction m_DebugCameraControls_DebugCameraRotation;
    private readonly InputAction m_DebugCameraControls_DebugCameraSpeed;
    public struct DebugCameraControlsActions
    {
        private @DebugCameraInputActions m_Wrapper;
        public DebugCameraControlsActions(@DebugCameraInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseDebugCamera => m_Wrapper.m_DebugCameraControls_CloseDebugCamera;
        public InputAction @DebugCameraMovement => m_Wrapper.m_DebugCameraControls_DebugCameraMovement;
        public InputAction @DebugCameraRotation => m_Wrapper.m_DebugCameraControls_DebugCameraRotation;
        public InputAction @DebugCameraSpeed => m_Wrapper.m_DebugCameraControls_DebugCameraSpeed;
        public InputActionMap Get() { return m_Wrapper.m_DebugCameraControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugCameraControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugCameraControlsActions instance)
        {
            if (m_Wrapper.m_DebugCameraControlsActionsCallbackInterface != null)
            {
                @CloseDebugCamera.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnCloseDebugCamera;
                @CloseDebugCamera.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnCloseDebugCamera;
                @CloseDebugCamera.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnCloseDebugCamera;
                @DebugCameraMovement.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraMovement;
                @DebugCameraMovement.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraMovement;
                @DebugCameraMovement.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraMovement;
                @DebugCameraRotation.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraRotation;
                @DebugCameraRotation.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraRotation;
                @DebugCameraRotation.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraRotation;
                @DebugCameraSpeed.started -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraSpeed;
                @DebugCameraSpeed.performed -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraSpeed;
                @DebugCameraSpeed.canceled -= m_Wrapper.m_DebugCameraControlsActionsCallbackInterface.OnDebugCameraSpeed;
            }
            m_Wrapper.m_DebugCameraControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseDebugCamera.started += instance.OnCloseDebugCamera;
                @CloseDebugCamera.performed += instance.OnCloseDebugCamera;
                @CloseDebugCamera.canceled += instance.OnCloseDebugCamera;
                @DebugCameraMovement.started += instance.OnDebugCameraMovement;
                @DebugCameraMovement.performed += instance.OnDebugCameraMovement;
                @DebugCameraMovement.canceled += instance.OnDebugCameraMovement;
                @DebugCameraRotation.started += instance.OnDebugCameraRotation;
                @DebugCameraRotation.performed += instance.OnDebugCameraRotation;
                @DebugCameraRotation.canceled += instance.OnDebugCameraRotation;
                @DebugCameraSpeed.started += instance.OnDebugCameraSpeed;
                @DebugCameraSpeed.performed += instance.OnDebugCameraSpeed;
                @DebugCameraSpeed.canceled += instance.OnDebugCameraSpeed;
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
        void OnCloseDebugCamera(InputAction.CallbackContext context);
        void OnDebugCameraMovement(InputAction.CallbackContext context);
        void OnDebugCameraRotation(InputAction.CallbackContext context);
        void OnDebugCameraSpeed(InputAction.CallbackContext context);
    }
}
