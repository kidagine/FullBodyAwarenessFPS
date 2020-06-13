using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Sprite _dpadUp;
    [SerializeField] private Sprite _dpadDown;
    [SerializeField] private Sprite _dpadLeft;
    [SerializeField] private Sprite _dpadRight;
    [SerializeField] private Sprite _leftStickHorizontal;
    [SerializeField] private Sprite _buttonNorth;
    [SerializeField] private Sprite _v;
    [SerializeField] private Sprite _l;
    [SerializeField] private Sprite _r;
    [SerializeField] private Sprite _ad;
    [SerializeField] private Sprite _x;
    [SerializeField] private Sprite _e;
    [SerializeField] private Sprite _q;
    private static readonly string _gamepadScheme = "Gamepad";
    private static readonly string _keyboardAndMouseScheme = "Keyboard&Mouse";


    public Sprite ResetSprite { get; private set; }
    public Sprite ExitMenuSprite { get; private set; }
    public Sprite NextOptionSprite { get; private set; }
    public Sprite DebugCameraSprite { get; private set; }
    public Sprite RestartSceneSprite { get; private set; }
    public Sprite SlowdownTimeSprite { get; private set; }
    public Sprite LightsSprite { get; private set; }
    public Sprite MoveLightsSprite { get; private set; }
    public Sprite ExitDebugCameraSprite { get; private set; }

    public static InputManager Instance { get; private set; }

    public event Action InputSchemeChangeEvent;


    void Awake()
    {
        CheckInstance();
    }

    private void CheckInstance()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void OnControlChanged(PlayerInput playerInput)
    {
        if (playerInput.user.controlScheme.Value.name.Equals(_gamepadScheme))
        {
            SetInputIconsToGamepad();
        }
        else if (playerInput.user.controlScheme.Value.name.Equals(_keyboardAndMouseScheme))
        {
            SetInputIconsToKeyboardAndMouse();
        }
    }

    private void SetInputIconsToGamepad()
    {
        ResetSprite = _buttonNorth;
        ExitMenuSprite = _dpadDown;
        NextOptionSprite = _dpadRight;
        DebugCameraSprite = _dpadUp;
        RestartSceneSprite = _dpadLeft;
        SlowdownTimeSprite = _leftStickHorizontal;
        LightsSprite = _dpadUp;
        MoveLightsSprite = _leftStickHorizontal;
        ExitDebugCameraSprite = _dpadDown;
        InputSchemeChangeEvent?.Invoke();
    }

    private void SetInputIconsToKeyboardAndMouse()
    {
        ResetSprite = _r;
        ExitMenuSprite = _v;
        NextOptionSprite = _e;
        DebugCameraSprite = _x;
        RestartSceneSprite = _q;
        SlowdownTimeSprite = _ad;
        LightsSprite = _l;
        MoveLightsSprite = _ad;
        ExitDebugCameraSprite = _x; 
        InputSchemeChangeEvent?.Invoke();
    }
}
