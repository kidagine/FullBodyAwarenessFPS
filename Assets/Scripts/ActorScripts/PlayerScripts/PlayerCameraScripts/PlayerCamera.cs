using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private PlayerInputSystem _playerInputSystem = default;
    [SerializeField] private GameObject _playerFPSCamera = default;
    [SerializeField] private GameObject _playerThirdPersonCamera = default;
    private IPlayerCamera _activePlayerCamera;


    public Vector2 CameraInput { get; set; }


    void Start()
    {
        if (_playerFPSCamera.TryGetComponent(out IPlayerCamera playerCamera))
            _activePlayerCamera = playerCamera;
    }

    public void SwapCamera()
    {
        if (_playerFPSCamera.activeSelf)
        {
            _playerFPSCamera.SetActive(false);
            _playerThirdPersonCamera.SetActive(true);
            if (_playerThirdPersonCamera.TryGetComponent(out IPlayerCamera playerCamera))
                _activePlayerCamera = playerCamera;
        }
        else
        {
            _playerFPSCamera.SetActive(true);
            _playerThirdPersonCamera.SetActive(false);
            if (_playerFPSCamera.TryGetComponent(out IPlayerCamera playerCamera))
                _activePlayerCamera = playerCamera;
        }
    }

    public void SetCameraInput(Vector2 cameraInput)
    {
        _activePlayerCamera.SetCameraInput(cameraInput);
    }

    public IPlayerCamera GetActiveCamera()
    {
        return _activePlayerCamera;
    }

    void OnEnable()
    {
        _playerInputSystem.enabled = true;
    }

    void OnDisable()
    {
        _playerInputSystem.enabled = false;
    }
}
