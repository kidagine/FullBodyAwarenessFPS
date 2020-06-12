#if UNITY_EDITOR
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugUIGeneral : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayCameraText = default;
    [SerializeField] private Slider _slowdownTimeSlider = default;
    [SerializeField] private GameObject _debugDefaultUI = default;
    [SerializeField] private GameObject _debugGeneralUI = default;
    [SerializeField] private GameObject _debugCameraUI = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private GameObject _displayCamera = default;
    [SerializeField] private GameObject _playerCamera = default;
    private readonly string _debugCameraText = "Debug Camera";
    private readonly string _gameCameraText = "Game Camera";
    private readonly int _slowdownTimeSliderSensitivity = 100;
    private Vector2 _slowdownTimeInput;
    private Coroutine _showDisplayCameraCoroutine;


    void Update()
    {
        if (_slowdownTimeInput.x != 0.0f)
        {
            _slowdownTimeSlider.value += _slowdownTimeInput.x / _slowdownTimeSliderSensitivity;
            float slowdownTime = 1.0f;
            slowdownTime -= _slowdownTimeSlider.value;
            Time.timeScale = slowdownTime;
        }    
    }

    public void SlowdownTime(Vector2 slowdownTimeInput)
    {
        if (gameObject.activeInHierarchy)
        {
            _slowdownTimeInput = slowdownTimeInput;
        }
    }

    public void RestartScene()
    {
        if (gameObject.activeInHierarchy)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void DebugCamera()
    {
        Debug.Log("tetest");
        if (gameObject.activeInHierarchy)
        {
            if (_showDisplayCameraCoroutine != null)
                StopCoroutine(_showDisplayCameraCoroutine);

            _showDisplayCameraCoroutine = StartCoroutine(ShowDisplayCameraCoroutine());

            _debugDefaultUI.SetActive(false);
            _debugCameraUI.SetActive(true);

            _playerCamera.SetActive(false);
            _debugCamera.SetActive(true);
            _displayCameraText.text = _debugCameraText;
        }
    }

    IEnumerator ShowDisplayCameraCoroutine()
    {
        yield return new WaitForSeconds(0.15f);
        _displayCamera.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        _displayCamera.SetActive(false);
    }

    public void ResetToDefault()
    {
        _slowdownTimeSlider.value = 0.0f;
        Time.timeScale = 1.0f;
    }
}
#endif