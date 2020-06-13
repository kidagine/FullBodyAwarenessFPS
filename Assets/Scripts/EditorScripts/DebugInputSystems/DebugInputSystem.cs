#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugInputSystem : MonoBehaviour
{
    [SerializeField] private GameDebugger _gameDebugger = default;
    private DebugInputActions _debugInputActions;


    void Awake()
    {
        _debugInputActions = new DebugInputActions();
        _debugInputActions.DebugControls.OpenDebug.performed += OpenDebug;
    }

    private void OpenDebug(InputAction.CallbackContext context)
    {
        _gameDebugger.OpenDebug();
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