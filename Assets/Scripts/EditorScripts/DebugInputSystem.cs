using UnityEngine;
using UnityEngine.InputSystem;
using UnityTemplateProjects;

public class DebugInputSystem : MonoBehaviour
{
    [SerializeField] private GameDebugger _gameDebugger = default;
    [SerializeField]private DebugCamera _debugCamera = default;
    private DebugInputActions _debugInputActions;


    void Awake()
    {
        _debugInputActions = new DebugInputActions();
        _debugInputActions.DebugControls.SetDebug.performed += SetDebug;
        _debugInputActions.DebugControls.DebugCamera.performed += DebugCamera;
        _debugInputActions.DebugControls.SlowdownTime.performed += SlowdownTime;
        _debugInputActions.DebugControls.RestartScene.performed += RestartScene;
        _debugInputActions.DebugControls.NextOption.performed += NextOption;
        _debugInputActions.DebugControls.CameraMovement.performed += SetCameraMovement;
        _debugInputActions.DebugControls.CameraRotation.performed += SetCameraRotation;
        _debugInputActions.DebugControls.SpeedMovement.performed += EnableCameraSpeed;
        _debugInputActions.DebugControls.SpeedMovement.canceled += DisableCameraSpeed;
    }

    public void SetDebug(InputAction.CallbackContext context)
    {
        _gameDebugger.SetDebugger();
    }

    public void DebugCamera(InputAction.CallbackContext context)
    {
        _gameDebugger.DebugCamera();
    }
    public void SlowdownTime(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _gameDebugger.SlowdownTime(context.ReadValue<Vector2>());
            Debug.Log(context.ReadValue<Vector2>());
        }
        if (context.canceled)
        {
            Debug.Log("stop");
        }
    }

    public void RestartScene(InputAction.CallbackContext context)
    {
        _gameDebugger.RestartScene();
    }

    public void NextOption(InputAction.CallbackContext context)
    {
        _gameDebugger.NextOption();
    }

    public void SetCameraMovement(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraMovement(context.ReadValue<Vector2>());
    }

    public void SetCameraRotation(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraRotation(context.ReadValue<Vector2>());
    }

    public void EnableCameraSpeed(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraSpeedEnabled(true);
    }

    public void DisableCameraSpeed(InputAction.CallbackContext context)
    {
        _debugCamera.SetCameraSpeedEnabled(false);
    }

    void OnEnable()
    {
        _debugInputActions.Enable();
    }

    void OnDisable()
    {
        _debugInputActions.Disable();
    }
}
