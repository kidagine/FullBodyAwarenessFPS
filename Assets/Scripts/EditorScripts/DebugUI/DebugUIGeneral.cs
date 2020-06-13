﻿#if UNITY_EDITOR
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugUIGeneral : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayCameraText = default;
    [SerializeField] private Slider _slowdownTimeSlider = default;
    [SerializeField] private Image _exitMenuImage = default;
    [SerializeField] private Image _nextOptionImage = default;
    [SerializeField] private Image _debugCameraImage = default;
    [SerializeField] private Image _restartSceneImage = default;
    [SerializeField] private Image _slowdownTimeImage = default;
    [SerializeField] private GameObject _debugDefaultUI = default;
    [SerializeField] private GameObject _debugGeneralUI = default;
    [SerializeField] private GameObject _debugCameraUI = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private GameObject _displayCamera = default;
    [SerializeField] private GameObject _playerCamera = default;
    private readonly int _slowdownTimeSliderSensitivity = 100;
    private Vector2 _slowdownTimeInput;


    void Start()
    {
        InputManager.Instance.InputSchemeChangeEvent += SetUIImages;
    }

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

    private void SetUIImages()
    {
        _exitMenuImage.sprite = InputManager.Instance.ExitMenuSprite;
        _nextOptionImage.sprite = InputManager.Instance.NextOptionSprite;
        _debugCameraImage.sprite = InputManager.Instance.DebugCameraSprite;
        _restartSceneImage.sprite = InputManager.Instance.RestartSceneSprite;
        _slowdownTimeImage.sprite = InputManager.Instance.SlowdownTimeSprite;
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

    public void OpenDebugCamera()
    {
        if (gameObject.activeInHierarchy)
        {
            _debugDefaultUI.SetActive(false);
            _debugCameraUI.SetActive(true);

            _playerCamera.SetActive(false);
            _debugCamera.SetActive(true);
        }
    }

    public void ResetToDefault()
    {
        _slowdownTimeSlider.value = 0.0f;
        Time.timeScale = 1.0f;
    }
}
#endif