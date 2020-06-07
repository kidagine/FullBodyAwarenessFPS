#if UNITY_EDITOR
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDebugger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _slowdownValueText = default;
    [SerializeField] private GameObject _gameDebuggerCanvas = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private PlayerInputSystem _playerInputSystem = default;
    private bool _isDebuggerActive;


    public void SetDebugger()
    {
        _isDebuggerActive = !_isDebuggerActive;
        if (_isDebuggerActive)
        {
            _gameDebuggerCanvas.SetActive(true);
        }
        else
        {
            _gameDebuggerCanvas.SetActive(false);
        }
    }

    public void SlowdownTime()
    {
        if (_isDebuggerActive)
        {
            if (Time.timeScale <= 0.1f)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale -= 0.1f;
            }
            _slowdownValueText.text = Time.timeScale.ToString("F1");
        }
    }

    public void RestartScene()
    {
        if (_isDebuggerActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void DebugCamera()
    {
        if (_isDebuggerActive)
        {
            if (_debugCamera.activeSelf)
            {
                _playerInputSystem.enabled = true;
                _debugCamera.SetActive(false);
            }
            else
            {
                _playerInputSystem.enabled = false;
                _debugCamera.SetActive(true);
            }
        }
    }
}
#endif