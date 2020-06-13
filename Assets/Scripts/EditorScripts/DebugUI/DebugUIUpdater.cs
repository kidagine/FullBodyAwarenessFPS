#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.UI;

public class DebugUIUpdater : MonoBehaviour
{
    [Header("Default Images")]
    [SerializeField] private Image _resetImage = default;
    [SerializeField] private Image _exitMenuImage = default;
    [SerializeField] private Image _nextOptionImage = default;
    [Header("General Images")]
    [SerializeField] private Image _debugCameraImage = default;
    [SerializeField] private Image _restartSceneImage = default;
    [SerializeField] private Image _slowdownTimeImage = default;
    [Header("Visuals Images")]
    [SerializeField] private Image _lightsImage = default;
    [SerializeField] private Image _moveLightsImage = default;
    [Header("Camera Images")]
    [SerializeField] private Image _exitDebugCameraImage = default;


    void Start()
    {
        InputManager.Instance.InputSchemeChangeEvent += SetUIImages;
    }

    private void SetUIImages()
    {
        _resetImage.sprite = InputManager.Instance.ResetSprite;
        _exitMenuImage.sprite = InputManager.Instance.ExitMenuSprite;
        _nextOptionImage.sprite = InputManager.Instance.NextOptionSprite;

        _debugCameraImage.sprite = InputManager.Instance.DebugCameraSprite;
        _restartSceneImage.sprite = InputManager.Instance.RestartSceneSprite;
        _slowdownTimeImage.sprite = InputManager.Instance.SlowdownTimeSprite;

        _lightsImage.sprite = InputManager.Instance.LightsSprite;
        _moveLightsImage.sprite = InputManager.Instance.MoveLightsSprite;

        _exitDebugCameraImage.sprite = InputManager.Instance.ExitDebugCameraSprite;
    }
}
#endif