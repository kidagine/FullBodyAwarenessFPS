#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugInputSystem : MonoBehaviour
{
    [SerializeField] private GameDebugger _gameDebugger = default;
    [SerializeField] private DebugUIDefault _debugUIDefault = default;
    [SerializeField] private DebugUICamera _debugUICamera = default;
    [SerializeField] private DebugUIGeneral _debugUIGeneral = default;
    [SerializeField] private DebugUIVisuals _debugUIVisuals = default;
    [SerializeField]private DebugCamera _debugCamera = default;
    private DebugInputActions _debugInputActions;


    void Awake()
    {
        _debugInputActions = new DebugInputActions();
        //_debugInputActions.DebugControls.SetDebug.performed += SetDebug;
        _debugInputActions.DebugControls.SetDebug.performed += SetDebug;
        //_debugInputActions.DebugControls.ExitMenu.performed += ExitMenu;
        //_debugInputActions.DebugControls.Reset.performed += StartReset;
        //_debugInputActions.DebugControls.Reset.canceled += StopReset;
        ////_debugInputActions.DebugControls.DebugCamera.performed += CloseDebugCamera;
        ////_debugInputActions.DebugControls.DebugCamera.performed += OpenDebugCamera;
        //_debugInputActions.DebugControls.SlowdownTime.performed += SlowdownTime;
        //_debugInputActions.DebugControls.MoveLights.performed += MoveLights;
        //_debugInputActions.DebugControls.SetLights.performed += SetLights;
        //_debugInputActions.DebugControls.RestartScene.performed += RestartScene;
        //_debugInputActions.DebugControls.NextOption.performed += NextOption;
        //_debugInputActions.DebugControls.CameraMovement.performed += SetCameraMovement;
        //_debugInputActions.DebugControls.CameraRotation.performed += SetCameraRotation;
        //_debugInputActions.DebugControls.SpeedMovement.performed += EnableCameraSpeed;
        //_debugInputActions.DebugControls.SpeedMovement.canceled += DisableCameraSpeed;
    }

    public void SetDebug(InputAction.CallbackContext context)
    {
        _gameDebugger.SetDebugger();
    }

    public void ExitMenu(InputAction.CallbackContext context)
    {
        _debugUIDefault.ExitMenu();
    }

    public void StopReset(InputAction.CallbackContext context)
    {
        _debugUIDefault.StopReset();
    }

    public void StartReset(InputAction.CallbackContext context)
    {
        _debugUIDefault.StartReset();
    }

    public void NextOption(InputAction.CallbackContext context)
    {
        _debugUIDefault.NextOption();
    }

    public void OpenDebugCamera(InputAction.CallbackContext context)
    {
        _debugUIGeneral.DebugCamera();
    }

    public void SlowdownTime(InputAction.CallbackContext context)
    {
        _debugUIGeneral.SlowdownTime(context.ReadValue<Vector2>());
    }

    //public void SlowdownTimez(InputAction.CallbackContext context)
    //{
    //    _debugUIGeneral.SlowdownTime(context.ReadValue<Vector2>());
    //}

    public void RestartScene(InputAction.CallbackContext context)
    {
        _debugUIGeneral.RestartScene();
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
    
    public void MoveLights(InputAction.CallbackContext context)
    {
        _debugUIVisuals.MoveLights(context.ReadValue<Vector2>());
    }

    public void SetLights(InputAction.CallbackContext context)
    {
        _debugUIVisuals.SetLights();
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
#endif