// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""e49a44f2-b0a4-400b-8c55-657bcdfe67d5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c7f47f77-d6bf-4b06-8f16-643427ecfd8e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5227899b-cc1e-4fa3-a3a4-f560a606a58d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a9151a73-fe94-4c36-a49e-1b8f8aee1ed4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""846a68df-45bd-4ee0-bf3e-c19e3c77533d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""Button"",
                    ""id"": ""0359f62a-0054-4a26-97f8-c206ac1345ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""e5d6d13b-7602-4b63-b7f1-d5920d8df652"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Holster"",
                    ""type"": ""Button"",
                    ""id"": ""ad350d75-93ee-494f-9577-0cfe2a892992"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""6cf33446-d83a-4b26-9284-50f6f2d24437"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseRun"",
                    ""type"": ""Button"",
                    ""id"": ""d15290eb-11e3-48e9-8067-018c1cef3805"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWalk"",
                    ""type"": ""Button"",
                    ""id"": ""07e71861-fc5c-4833-85ab-e5e82242a7f8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d73baec0-22a5-448d-98ce-2abdeab49598"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""22c78b2d-2206-4453-9458-a437b48c3bd0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f10cda3a-ec96-40a2-be0b-0161f29273a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""731def4f-8f94-449b-bcbd-3596da3a3250"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""425dc00e-cbe9-4f98-994c-dc7151c43487"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""30384ecb-c7a7-4ba3-94bd-df5fc8a11fe5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2aa0a601-5203-444f-9e4e-7efe8ea4dd1e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29ff31f0-9e30-4b3d-b809-b72c492c6648"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e3f5fa45-efdd-4325-b327-ebe0c6e7187a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2d21b138-d220-4e2c-87b2-25ef5b104a7a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""491f826d-5419-4fb6-8f19-0e90974f6eb5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""64e43c46-1245-403f-a52a-b47b5b491d57"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=25,y=25)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60e3e1f9-d1ea-4a98-82a9-d7ad8a51d704"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.35,y=0.35)"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a457c5dd-bb8d-4b90-9965-a7174ff24774"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a285149-f273-47d5-beac-0c98f36061fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6637bcae-cd1a-4be5-88dd-40cf72c8dcf3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""828a1f63-fbae-454c-bfd0-da3eed9d3340"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1772a9b-2989-46ef-94b6-fa0f698aecd0"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Holster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335c2692-4b8d-4bc5-b315-e4b297e3fa62"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Holster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ControllerRun"",
                    ""id"": ""ed27f7af-9094-41b2-96fe-64c2e7ab7187"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f915274c-4e6e-4c95-88d3-e0c3b72ac448"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""818789a3-575f-43d8-b560-d29d6fb65daa"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASDRun"",
                    ""id"": ""85ef2e72-cc72-409a-9d8c-f7d4d9802594"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""c98013a6-6ff3-4fe9-8c29-2fcbe6aba773"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""b219fd28-43cf-4509-a17d-fe784e9e880c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowsRun"",
                    ""id"": ""901d7fab-f77b-413f-afe0-2667b6018cfb"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8ceb5910-0223-4ac0-9a19-ebfe8fa15fcb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""eeecdaf5-ca75-4d48-859c-add320e2a606"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d1f19c47-b416-4c28-8727-854baee90f9f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PauseRun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23b53618-ba8e-4908-8e77-ee2ecf746619"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PauseRun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""398901e1-53b3-410c-b580-56505bdc5a27"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a369ff68-4b19-4b72-9832-4d5377ff0d84"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""051d0eff-9db1-4d65-aeff-6422e73f86ae"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee18041c-c0ea-438b-b26a-e6518f310a7e"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1528b4d9-a3b5-4680-a36f-ecc657344797"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwitchWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""592fa56c-e8d6-4324-acbb-d8d9aeb7eb11"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SwitchWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
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
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_Camera = m_PlayerControls.FindAction("Camera", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Crouch = m_PlayerControls.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerControls_Prone = m_PlayerControls.FindAction("Prone", throwIfNotFound: true);
        m_PlayerControls_Shoot = m_PlayerControls.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControls_Holster = m_PlayerControls.FindAction("Holster", throwIfNotFound: true);
        m_PlayerControls_Run = m_PlayerControls.FindAction("Run", throwIfNotFound: true);
        m_PlayerControls_PauseRun = m_PlayerControls.FindAction("PauseRun", throwIfNotFound: true);
        m_PlayerControls_SwitchWalk = m_PlayerControls.FindAction("SwitchWalk", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_Camera;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Crouch;
    private readonly InputAction m_PlayerControls_Prone;
    private readonly InputAction m_PlayerControls_Shoot;
    private readonly InputAction m_PlayerControls_Holster;
    private readonly InputAction m_PlayerControls_Run;
    private readonly InputAction m_PlayerControls_PauseRun;
    private readonly InputAction m_PlayerControls_SwitchWalk;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @Camera => m_Wrapper.m_PlayerControls_Camera;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Crouch => m_Wrapper.m_PlayerControls_Crouch;
        public InputAction @Prone => m_Wrapper.m_PlayerControls_Prone;
        public InputAction @Shoot => m_Wrapper.m_PlayerControls_Shoot;
        public InputAction @Holster => m_Wrapper.m_PlayerControls_Holster;
        public InputAction @Run => m_Wrapper.m_PlayerControls_Run;
        public InputAction @PauseRun => m_Wrapper.m_PlayerControls_PauseRun;
        public InputAction @SwitchWalk => m_Wrapper.m_PlayerControls_SwitchWalk;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Camera.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCamera;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Prone.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnProne;
                @Shoot.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Holster.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHolster;
                @Holster.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHolster;
                @Holster.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHolster;
                @Run.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @PauseRun.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseRun;
                @PauseRun.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseRun;
                @PauseRun.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseRun;
                @SwitchWalk.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWalk;
                @SwitchWalk.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWalk;
                @SwitchWalk.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWalk;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Holster.started += instance.OnHolster;
                @Holster.performed += instance.OnHolster;
                @Holster.canceled += instance.OnHolster;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @PauseRun.started += instance.OnPauseRun;
                @PauseRun.performed += instance.OnPauseRun;
                @PauseRun.canceled += instance.OnPauseRun;
                @SwitchWalk.started += instance.OnSwitchWalk;
                @SwitchWalk.performed += instance.OnSwitchWalk;
                @SwitchWalk.canceled += instance.OnSwitchWalk;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnHolster(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnPauseRun(InputAction.CallbackContext context);
        void OnSwitchWalk(InputAction.CallbackContext context);
    }
}
