using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private ThirdPersonCamera _thirdPersonCamera = default;
    [SerializeField] private FPSCamera _fpsCamera = default;
    [SerializeField] private bool _thirdPersonCameraOn = true;
    private ICamera _camera;

	public bool ThirdPersonCameraOn { get { return _thirdPersonCameraOn; } private set { } }


	void Awake()
    {
        if (ThirdPersonCameraOn)
        {
            _thirdPersonCamera.Activate();
            _fpsCamera.Deactivate();
            _camera = _thirdPersonCamera.GetComponent<ICamera>();
        }
        else
        {
            _thirdPersonCamera.Deactivate();
            _fpsCamera.Activate();
            _camera = _fpsCamera.GetComponent<ICamera>();
        }
    }

    public void SetLookInput(Vector2 lookInput)
    {
        _camera.LookInput = lookInput;
    }

    public void GetLookDirection(out Vector3 forward, out Vector3 right)
    {
        _camera.GetLookDirection(out forward, out right);
    }

    public void ToggleCameraAction()
    {
        if (ThirdPersonCameraOn)
        {
            _thirdPersonCameraOn = false;
            _thirdPersonCamera.Deactivate();
            _fpsCamera.Activate();
            _camera = _fpsCamera.GetComponent<ICamera>();
        }
        else
        {
            _thirdPersonCameraOn = true;
            _thirdPersonCamera.Activate();
            _fpsCamera.Deactivate();
            _camera = _thirdPersonCamera.GetComponent<ICamera>();
        }
    }
}
