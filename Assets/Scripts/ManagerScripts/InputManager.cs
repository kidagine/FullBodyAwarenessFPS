using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private static readonly string _gamepadScheme = "Gamepad";
    private static readonly string _keyboardAndMouseScheme = "Keyboard&Mouse";
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
        Debug.Log("GAMEPAD");
        InputSchemeChangeEvent?.Invoke();
    }

    private void SetInputIconsToKeyboardAndMouse()
    {
        Debug.Log("Keyboard&Mouse");
        InputSchemeChangeEvent?.Invoke();
    }
}
