using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerCamera))]
[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    private PlayerCamera _playerCamera;
    private PlayerMovement _playerMovement;
    private PlayerInputActions _playerInputActions;


    void Awake()
    {
        _playerCamera = GetComponent<PlayerCamera>();
        _playerMovement = GetComponent<PlayerMovement>();
        PlayerInputSetup();
    }

    private void PlayerInputSetup()
    {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Gameplay.Movement.performed += SetMovement;
        _playerInputActions.Gameplay.Look.performed += SetLook;
        _playerInputActions.Gameplay.Sprint.performed += Sprint;
        _playerInputActions.Gameplay.Crouch.performed += ToggleCrouch;
        _playerInputActions.Gameplay.Walk.performed += ToggleWalk;
        _playerInputActions.Gameplay.Camera.performed += ToggleCamera;
    }

    private void SetMovement(InputAction.CallbackContext context)
    {
        _playerMovement.MovementInput = context.ReadValue<Vector2>();
    }

    private void SetLook(InputAction.CallbackContext context)
    {
        _playerCamera.SetLookInput(context.ReadValue<Vector2>());
    }

    private void Sprint(InputAction.CallbackContext context)
    {
        _playerMovement.SprintAction();
    }

    private void ToggleCrouch(InputAction.CallbackContext context)
    {
        _playerMovement.ToggleCrouchAction();
    }

    private void ToggleWalk(InputAction.CallbackContext context)
    {
        _playerMovement.ToggleWalkAction();
    }

    private void ToggleCamera(InputAction.CallbackContext context)
    {
        _playerCamera.ToggleCameraAction();
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
