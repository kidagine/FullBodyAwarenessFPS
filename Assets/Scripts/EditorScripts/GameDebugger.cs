#if UNITY_EDITOR
using UnityEngine;

public class GameDebugger : MonoBehaviour
{
    [SerializeField] private GameObject _gameDebuggerCanvas = default;
    [SerializeField] private GameObject _debugGeneralUI = default;
    [SerializeField] private GameObject _debugVisualsUI = default;
    [SerializeField] private PlayerInputSystem _playerInputSystem = default;


    void Start()
    {
        if (_gameDebuggerCanvas.activeSelf)
        {
            _playerInputSystem.enabled = false;
        }
        else
        {
            _playerInputSystem.enabled = true;
        }
    }

    public void SetDebugger()
    {
        if (!_gameDebuggerCanvas.activeSelf)
        {
            _playerInputSystem.enabled = false;
            _gameDebuggerCanvas.SetActive(true);
        }
    }
}
#endif