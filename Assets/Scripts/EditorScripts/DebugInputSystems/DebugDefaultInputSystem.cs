#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugDefaultInputSystem : MonoBehaviour
{
    [SerializeField] private DebugUIDefault _debugUIDefault = default;
    [SerializeField] private DebugUIGeneral _debugUIGeneral = default;
    [SerializeField] private DebugUIVisuals _debugUIVisuals = default;
    private DebugDefaultInputActions _debugDefaultInputActions;


    void Awake()
    {
        _debugDefaultInputActions = new DebugDefaultInputActions();
        _debugDefaultInputActions.DebugDefaultControls.CloseDebug.performed += CloseDebug;
        _debugDefaultInputActions.DebugDefaultControls.Reset.performed += StartReset;
        _debugDefaultInputActions.DebugDefaultControls.Reset.canceled += StopReset;
        _debugDefaultInputActions.DebugDefaultControls.NextOption.performed += NextOption;
        _debugDefaultInputActions.DebugDefaultControls.OpenDebugCamera.performed += OpenDebugCamera;
        _debugDefaultInputActions.DebugDefaultControls.RestartScene.performed += RestartScene;
        _debugDefaultInputActions.DebugDefaultControls.SlowdownTime.performed += SlowdownTime;
        _debugDefaultInputActions.DebugDefaultControls.MoveLights.performed += MoveLights;
        _debugDefaultInputActions.DebugDefaultControls.SetLights.performed += SetLights;
    }

    private void CloseDebug(InputAction.CallbackContext context)
    {
        _debugUIDefault.CloseDebug();
    }

    private void StartReset(InputAction.CallbackContext context)
    {
        _debugUIDefault.StartReset();
    }

    private void StopReset(InputAction.CallbackContext context)
    {
        _debugUIDefault.StopReset();
    }

    private void NextOption(InputAction.CallbackContext context)
    {
        _debugUIDefault.NextOption();
    }

    private void OpenDebugCamera(InputAction.CallbackContext context)
    {
        _debugUIGeneral.OpenDebugCamera();
    }

    private void RestartScene(InputAction.CallbackContext context)
    {
        _debugUIGeneral.RestartScene();
    }

    private void SlowdownTime(InputAction.CallbackContext context)
    {
        _debugUIGeneral.SlowdownTime(context.ReadValue<Vector2>());
    }

    private void MoveLights(InputAction.CallbackContext context)
    {
        _debugUIVisuals.MoveLights(context.ReadValue<Vector2>());
    }

    private void SetLights(InputAction.CallbackContext context)
    {
        _debugUIVisuals.SetLights();
    }

    void OnEnable()
    {
        _debugDefaultInputActions.Enable();
    }

    void OnDisable()
    {
        _debugDefaultInputActions.Disable();
    }
}
#endif