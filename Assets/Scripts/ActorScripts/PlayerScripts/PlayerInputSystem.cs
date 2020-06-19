using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : MonoBehaviour
{
    [SerializeField] private Player _player = default;
    [SerializeField] private PlayerMovement _playerMovementScript = default;
    [SerializeField] private PlayerCamera _playerCamera = default;
    private PlayerInputActions _playerInputActions;


    void Awake()
    {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.PlayerControls.Holster.performed += ToggleHolster;
        _playerInputActions.PlayerControls.ShootGun.performed += ShootGun;
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

    private void ToggleHolster(InputAction.CallbackContext context)
    {
        _player.ToggleHolster();
    }

    private void ShootGun(InputAction.CallbackContext context)
    {
        _player.ShootGun();
    }

    private void SetMove(InputAction.CallbackContext context)
    {
        _playerMovementScript.MovementInput = context.ReadValue<Vector2>();
    }

    private void SetCamera(InputAction.CallbackContext context)
    {
        _playerCamera.SetCameraInput(context.ReadValue<Vector2>());
    }

    private void SwapCamera(InputAction.CallbackContext context)
    {
        _playerCamera.SwapCamera();
    }

    private void Jump(InputAction.CallbackContext context)
    {
        _playerMovementScript.Jump();
    }

    private void Crouch(InputAction.CallbackContext context)
    {
        _playerMovementScript.Crouch();
    }

    private void Prone(InputAction.CallbackContext context)
    {
        _playerMovementScript.Prone();
    }

    private void Slide(InputAction.CallbackContext context)
    {
        _playerMovementScript.Slide();
    }

    private void Run(InputAction.CallbackContext context)
    {
        _playerMovementScript.Run();
        //else if (context.canceled)
        //{
        //    _playerMovementScript.StopRun();
        //}
    }

    private void PauseRun(InputAction.CallbackContext context)
    {
        // _playerScript.PauseRun();
    }

    private void SwitchWalk(InputAction.CallbackContext context)
    {
        _playerMovementScript.SwitchWalkMode();
    }

    void OnEnable()
    {
        _playerInputActions.Enable();
    }

    void OnDisable()
    {
        _playerInputActions.Disable();
    }
}
