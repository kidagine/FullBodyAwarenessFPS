using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovementScript;
    [SerializeField] private PlayerCamera _playerCamera;
    private PlayerInputActions _playerInputActions;


    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.PlayerControls.Move.performed += SetMove;
        _playerInputActions.PlayerControls.Camera.performed += SetCamera;
        _playerInputActions.PlayerControls.SwapCamera.performed += SwapCamera;
        _playerInputActions.PlayerControls.Jump.performed += Jump;
        _playerInputActions.PlayerControls.Crouch.performed += Crouch;
        _playerInputActions.PlayerControls.Crouch.performed += Slide;
        _playerInputActions.PlayerControls.Prone.performed += Prone;
        _playerInputActions.PlayerControls.Run.performed += Run;
        _playerInputActions.PlayerControls.PauseRun.performed += PauseRun;
        _playerInputActions.PlayerControls.SwitchWalk.performed += SwitchWalk;
    }

    public void SetMove(InputAction.CallbackContext context)
    {
        _playerMovementScript.MovementInput = context.ReadValue<Vector2>();
    }

    public void SetCamera(InputAction.CallbackContext context)
    {
        //_playerCamera.CameraInput = context.ReadValue<Vector2>();
        _playerCamera.SetCameraInput(context.ReadValue<Vector2>());
    }

    public void SwapCamera(InputAction.CallbackContext context)
    {
        _playerCamera.SwapCamera();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        _playerMovementScript.Jump();
    }

    public void Crouch(InputAction.CallbackContext context)
    {
        _playerMovementScript.Crouch();
    }

    public void Prone(InputAction.CallbackContext context)
    {
        _playerMovementScript.Prone();
    }

    public void Slide(InputAction.CallbackContext context)
    {
        _playerMovementScript.Slide();
    }

    public void Run(InputAction.CallbackContext context)
    {
        _playerMovementScript.Run();
        //else if (context.canceled)
        //{
        //    _playerMovementScript.StopRun();
        //}
    }

    public void PauseRun(InputAction.CallbackContext context)
    {
        // _playerScript.PauseRun();
    }

    public void SwitchWalk(InputAction.CallbackContext context)
    {
        _playerMovementScript.SwitchWalkMode();
    }

        private void OnEnable()
        {
            _playerInputActions.Enable();
        }

        private void OnDisable()
        {
            _playerInputActions.Disable();
        }
}
