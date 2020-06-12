#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugCameraInputSystem : MonoBehaviour
{
    [SerializeField] private DebugUICamera _debugUICamera = default;
    [SerializeField] private DebugCamera _debugCamera = default;
    private DebugCameraInputActions _debugCameraInputActions;


    void Awake()
    {
        _debugCameraInputActions = new DebugCameraInputActions();
        _debugCameraInputActions.DebugCameraControls.CloseDebugCamera.performed += CloseDebugCamera;
        _debugCameraInputActions.DebugCameraControls.DebugCameraMovement.performed += SetDebugCameraMovement;
        _debugCameraInputActions.DebugCameraControls.DebugCameraRotation.performed += SetDebugCameraRotation;
        _debugCameraInputActions.DebugCameraControls.DebugCameraSpeed.performed += EnableCameraSpeed;
        _debugCameraInputActions.DebugCameraControls.DebugCameraSpeed.canceled += DisableCameraSpeed;
    }

    private void CloseDebugCamera(InputAction.CallbackContext context)
    {
        _debugUICamera.CloseDebugCamera();
    }

    private void SetDebugCameraMovement(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraMovement(context.ReadValue<Vector2>());
    }

    private void SetDebugCameraRotation(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraRotation(context.ReadValue<Vector2>());
    }

    private void EnableCameraSpeed(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraSpeedEnabled(true);
    }

    private void DisableCameraSpeed(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraSpeedEnabled(false);
    }

    void OnEnable()
    {
        _debugCameraInputActions.Enable();
    }

    void OnDisable()
    {
        _debugCameraInputActions.Disable();
    }
}
#endif