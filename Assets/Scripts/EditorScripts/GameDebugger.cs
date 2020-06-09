#if UNITY_EDITOR
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDebugger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _slowdownValueText = default;
    [SerializeField] private TextMeshProUGUI _displayCameraText = default;
    [SerializeField] private GameObject _gameDebuggerCanvas = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private GameObject _displayCamera = default;
    [SerializeField] private GameObject _playerCamera = default;
    private readonly string _debugCameraText = "Debug Camera";
    private readonly string _gameCameraText = "Game Camera";
    private Coroutine _showDisplayCameraCoroutine;
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
        if (_showDisplayCameraCoroutine != null)
            StopCoroutine(_showDisplayCameraCoroutine);

        _showDisplayCameraCoroutine = StartCoroutine(ShowDisplayCameraCoroutine());
        if (_isDebuggerActive)
        {
            if (_debugCamera.activeSelf)
            {
                _playerCamera.SetActive(true);
                _debugCamera.SetActive(false);
                _displayCameraText.text = _gameCameraText;
            }
            else
            {
                _playerCamera.SetActive(false);
                _debugCamera.SetActive(true);
                _displayCameraText.text = _debugCameraText;
            }
        }
    }

    IEnumerator ShowDisplayCameraCoroutine()
    {
        yield return new WaitForSeconds(0.15f);
        _displayCamera.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        _displayCamera.SetActive(false);
    }
}
#endif