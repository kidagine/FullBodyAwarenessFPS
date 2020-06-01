using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _playerHead;
    [SerializeField] private Transform _playerEyes;
    [SerializeField] private Transform _playerCameraPoint;
    [SerializeField] private Transform _playerPivot;
    [Range(1.0f, 10f)] private readonly float _mouseSensitivity = 10.0f;
    private Vector3 rotMoveables;
    private float _xRotation;
    private readonly int _maximuDownwardsYRotation = 85;
    private readonly int _maximumUpwardsYRotation = -90;
    public Vector2 CameraInput { get; set; }


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RotateCamera();
        _playerCameraPoint.position = _playerHead.position;
    }

    private void LateUpdate()
    {
    }

    private void RotateCamera()
    {
        if (!_playerMovement.LockMovement)
        {
            float mouseX = CameraInput.x * Time.deltaTime;
            float mouseY = CameraInput.y * Time.deltaTime;

            float rotAmountX = mouseX * _mouseSensitivity;
            float rotAmountY = mouseY * _mouseSensitivity;

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
    }

    private void SetPlayerRotation(Vector3 rotMoveables)
    {
        _playerCameraPoint.rotation = Quaternion.Euler(rotMoveables);
        Quaternion cameraRotation = Quaternion.Euler(rotMoveables);

        //Rotate player when camera goes sideways
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

        //Rotate player pivot if they run and press A or D
        if (_playerMovement.Move.magnitude > 0.0f)
        {
            if (_playerMovement.IsRunning && Input.GetKey(KeyCode.A) || _playerMovement.IsRunning && Input.GetKey(KeyCode.D))
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    _playerPivot.transform.Rotate(0.0f, -30.0f, 0.0f);
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    _playerPivot.transform.Rotate(0.0f, 30.0f, 0.0f);
                }
            }
            else
            {
                _playerPivot.transform.rotation = Quaternion.identity;
            }
            Quaternion cameraPointRotation = _playerCameraPoint.transform.rotation;
            _player.transform.localRotation = Quaternion.Slerp(_player.transform.localRotation, cameraPointRotation, Time.deltaTime * _playerMovement.Move.magnitude * 30.0f);
        }
    }
}