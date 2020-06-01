using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : MonoBehaviour
{
    [SerializeField] private Player _playerScript;
    [SerializeField] private PlayerMovement _playerMovementScript;
    [SerializeField] private PlayerCamera _playerCamera;
    private PlayerInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.PlayerControls.Move.performed += SetMove;
        playerInputActions.PlayerControls.Camera.performed += SetCamera;
        playerInputActions.PlayerControls.Jump.performed += Jump;
        playerInputActions.PlayerControls.Crouch.performed += Crouch;
        playerInputActions.PlayerControls.Crouch.performed += Slide;
        playerInputActions.PlayerControls.Prone.performed += Prone;
        playerInputActions.PlayerControls.Run.performed += Run;
        playerInputActions.PlayerControls.PauseRun.performed += PauseRun;
        playerInputActions.PlayerControls.SwitchWalk.performed += SwitchWalk;
    }

    public void SetMove(InputAction.CallbackContext context)
    {
        _playerMovementScript.MovementInput = context.ReadValue<Vector2>();
    }

    public void SetCamera(InputAction.CallbackContext context)
    {
        _playerCamera.CameraInput = context.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.Jump();
        }
    }

    public void Crouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.Crouch();
        }
    }

    public void Prone(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.Prone();
        }
    }

    public void Slide(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.Slide();
        }
    }

    public void Run(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.Run();
        }
        else if (context.canceled)
        {
            _playerMovementScript.StopRun();
        }
    }

    public void PauseRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
           // _playerScript.PauseRun();
        }
    }

    public void SwitchWalk(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerMovementScript.SwitchWalkMode();
        }
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }
}
