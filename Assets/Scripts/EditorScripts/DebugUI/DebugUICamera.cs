#if UNITY_EDITOR
using TMPro;
using UnityEngine;

public class DebugUICamera : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayCameraText = default;
    [SerializeField] private Animator _displayCameraAnimator = default;
    [SerializeField] private GameObject _debugDefaultUI = default;
    [SerializeField] private GameObject _debugGeneralUI = default;
    [SerializeField] private GameObject _debugCameraUI = default;
    [SerializeField] private GameObject _debugCamera = default;
    [SerializeField] private GameObject _playerCamera = default;
    private readonly string _debugCameraText = "Debug Camera";
    private readonly string _gameCameraText = "Game Camera";


    public void CloseDebugCamera()
    {
        if (gameObject.activeInHierarchy)
        {
            _debugDefaultUI.SetActive(true);
            _playerCamera.SetActive(true);
            _debugCamera.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnEnable()
    {
        _displayCameraText.text = _debugCameraText;
        _displayCameraAnimator.SetTrigger("Display");
    }

    void OnDisable()
    {
        _displayCameraText.text = _gameCameraText;
        _displayCameraAnimator.SetTrigger("Display");
    }
}
#endif