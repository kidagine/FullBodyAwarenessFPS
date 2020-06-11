#if UNITY_EDITOR
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDebugger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayCameraText = default;
    [SerializeField] private Slider _slowdownTimeSlider = default;
    [SerializeField] private GameObject _gameDebuggerCanvas = default;
    [SerializeField] private GameObject _debugGeneralUI = default;
    [SerializeField] private GameObject _debugVisualsUI = default;
    [SerializeField] private GameObject _debugCameraUI = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private GameObject _displayCamera = default;
    [SerializeField] private GameObject _playerCamera = default;
    [SerializeField] private PlayerInputSystem _playerInputSystem = default;
    private readonly string _debugCameraText = "Debug Camera";
    private readonly string _gameCameraText = "Game Camera";
    private Coroutine _showDisplayCameraCoroutine;


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
        if (_gameDebuggerCanvas.activeSelf)
        {
            _playerInputSystem.enabled = true;
            _gameDebuggerCanvas.SetActive(false);
        }
        else
        {
            _playerInputSystem.enabled = false;
            _gameDebuggerCanvas.SetActive(true);
        }
    }

    public void SlowdownTime(Vector2 slowdownTimeInput)
    {
        if (_gameDebuggerCanvas.activeSelf)
        {
            _slowdownTimeSlider.value = slowdownTimeInput.x;
        }
    }

    public void RestartScene()
    {
        if (_gameDebuggerCanvas.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void DebugCamera()
    {
        if (_showDisplayCameraCoroutine != null)
            StopCoroutine(_showDisplayCameraCoroutine);

        _showDisplayCameraCoroutine = StartCoroutine(ShowDisplayCameraCoroutine());
        if (_gameDebuggerCanvas.activeSelf)
        {
            if (_debugCamera.activeSelf)
            {
                _debugGeneralUI.SetActive(true);
                _debugCameraUI.SetActive(false);

                _playerCamera.SetActive(true);
                _debugCamera.SetActive(false);
                _displayCameraText.text = _gameCameraText;
            }
            else
            {
                _debugGeneralUI.SetActive(false);
                _debugCameraUI.SetActive(true);

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

    public void NextOption()
    {
        if (_debugGeneralUI.activeSelf)
        {
            _debugGeneralUI.SetActive(false);
            _debugVisualsUI.SetActive(true);
        }
        else if (_debugVisualsUI.activeSelf)
        {
            _debugGeneralUI.SetActive(true);
            _debugVisualsUI.SetActive(false);
        }
    }
}
#endif