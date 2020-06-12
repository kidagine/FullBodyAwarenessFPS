#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugDefaultInputSystem : MonoBehaviour
{
    [SerializeField] private DebugUIGeneral _debugUIGeneral = default;
    private DebugDefaultInputActions _debugDefaultInputActions;


    void Awake()
    {
        _debugDefaultInputActions = new DebugDefaultInputActions();
        _debugDefaultInputActions.DebugCameraControls.SetCamera.performed += SetDebug;
    }

    public void SetDebug(InputAction.CallbackContext context)
    {
        _debugUIGeneral.DebugCamera();
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