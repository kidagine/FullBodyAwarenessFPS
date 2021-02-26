using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FPSCamera : MonoBehaviour, ICamera
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _playerHead;
    [SerializeField] private Transform _playerCameraPoint;
    [SerializeField] private Transform _playerPivot;
    [Range(1.0f, 10f)] private readonly float _cameraSensitivity = 10.0f;
    private readonly int _maximuDownwardsYRotation = 85;
    private readonly int _maximumUpwardsYRotation = -90;
    private Vector3 rotMoveables;
    private float _xRotation;

    public Vector2 LookInput { get; set; }


    void Update()
    {
        RotateCamera();
        _playerCameraPoint.position = _playerHead.position;
    }

    private void RotateCamera()
    {
        float rotAmountX = LookInput.x * Time.deltaTime * _cameraSensitivity;
        float rotAmountY = LookInput.y * Time.deltaTime * _cameraSensitivity;

        _xRotation -= rotAmountY;

        Vector3 rotCamera = transform.rotation.eulerAngles;
        rotMoveables = _playerCameraPoint.rotation.eulerAngles;

        rotCamera.x -= rotAmountY;
        rotMoveables.y += rotAmountX;

        if (_xRotation > _maximuDownwardsYRotation)
        {
            _xRotation = _maximuDownwardsYRotation;
            rotCamera.x = _maximuDownwardsYRotation;
        }
        else if (_xRotation < _maximumUpwardsYRotation)
        {
            _xRotation = _maximumUpwardsYRotation;
            rotCamera.x = _maximumUpwardsYRotation;
        }

        transform.rotation = Quaternion.Euler(rotCamera);
        SetPlayerRotation(rotMoveables);
    }

    private void SetPlayerRotation(Vector3 rotMoveables)
    {
        _playerCameraPoint.rotation = Quaternion.Euler(rotMoveables);
        Quaternion cameraRotation = Quaternion.Euler(rotMoveables);

        int angle = (int)Quaternion.Angle(cameraRotation, _player.transform.rotation);
        Vector3 side = Vector3.Cross(cameraRotation * Vector3.forward, _player.transform.rotation * Vector3.forward);
        if (angle >= 90)
        {
            if (side.y > 0.0f)
            {
                _player.transform.Rotate(0.0f, -90, 0.0f);
            }
            if (side.y < 0.0f)
            {
                _player.transform.Rotate(0.0f, 90, 0.0f);
            }
        }

		if (_playerMovement.MovementVector.magnitude > 0.0f)
		{
			_playerPivot.transform.rotation = Quaternion.identity;
			Quaternion cameraPointRotation = _playerCameraPoint.transform.rotation;
			_player.transform.localRotation = Quaternion.Slerp(_player.transform.localRotation, cameraPointRotation, Time.deltaTime * _playerMovement.MovementVector.magnitude * 30.0f);
		}
	}

    public void GetLookDirection(out Vector3 forward, out Vector3 right)
    {
        forward = new Vector3(transform.forward.x, 0.0f, transform.forward.z);
        right = new Vector3(transform.right.x, 0.0f, transform.right.z);
        forward.Normalize();
        right.Normalize();
        //return forward * MovementInput.y + right * MovementInput.x;
    }

    public void Activate()
    {
        transform.parent.gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
