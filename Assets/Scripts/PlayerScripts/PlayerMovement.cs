using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerCamera))]
[RequireComponent(typeof(PlayerFPSMovement))]
[RequireComponent(typeof(PlayerThirdPersonMovement))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerIK _playerIK = default;
    [SerializeField] private LayerMask _groundLayerMask = default;
    [Range(0.0f, 7.0f)]
    [SerializeField] private float _walkSpeed = 5.0f;
    [Range(0.0f, 10.0f)]
    [SerializeField] private float _jogSpeed = 7.0f;
    [Range(0.0f, 12.0f)]
    [SerializeField] private float _sprintSpeed = 10.0f;
    [Range(0.0f, 5.0f)]
    [SerializeField] private float _crouchSpeed = 2.0f;
    private Animator _animator;
    private PlayerCamera _playerCamera;
    private PlayerFPSMovement _playerFPSMovement;
    private PlayerThirdPersonMovement _playerThirdPersonMovement;
    private float _movementSpeed;
    private bool _isWalkModeOn;
    private bool _isCrouching;

    public Vector3 MovementVector { get; private set; }
    public Vector2 MovementInput { private get; set; }


    void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerCamera = GetComponent<PlayerCamera>();
        _playerFPSMovement = GetComponent<PlayerFPSMovement>();
        _playerThirdPersonMovement = GetComponent<PlayerThirdPersonMovement>();
    }

	void Start()
	{
        _movementSpeed = _jogSpeed;
	}

	void Update()
    {
        if (_playerCamera.ThirdPersonCameraOn)
        {
            _playerThirdPersonMovement.Movement(_movementSpeed, MovementInput);
        }
        else 
        {
            _playerFPSMovement.Movement(_movementSpeed, MovementInput);
        }
        CheckGrounded();
    }

    private void CheckGrounded()
    {
        Vector3 rightFootPosition = _playerIK.GetAdjustedFootTarget(HumanBodyBones.RightToes);
        Vector3 leftFootPosition = _playerIK.GetAdjustedFootTarget(HumanBodyBones.LeftToes);
        IsFootGrounded(rightFootPosition, ref _playerIK._rightFootIKPosition, ref _playerIK._rightFootIKRotation);
        IsFootGrounded(leftFootPosition, ref _playerIK._leftFootIKPosition, ref _playerIK._leftFootIKRotation);
    }

    private bool IsFootGrounded(Vector3 footPosition, ref Vector3 footIKPosition, ref Quaternion footIKRotations)
    {
        footIKPosition = Vector3.zero;
        if (Physics.Raycast(footPosition, Vector3.down, out RaycastHit hit, 0.5f, _groundLayerMask))
        {
            footIKPosition = footPosition;
            footIKPosition.y = hit.point.y;
            footIKRotations = Quaternion.FromToRotation(Vector3.up, hit.normal) * transform.rotation;
            return true;
        }
        return false;
    }

    public void StartSprintAction()
    {
        _animator.SetBool("IsSprinting", true);
        _movementSpeed = _sprintSpeed;
    }

    public void StopSprintAction()
    {
        _animator.SetBool("IsSprinting", false);
        _animator.SetBool("IsWalkModeOn", false);
        _isWalkModeOn = false;
        _movementSpeed = _jogSpeed;
    }

    public void ToggleCrouchAction()
    {
        if (_isCrouching)
        {
            _animator.SetBool("IsCrouching", false);
            _isCrouching = false;
            _movementSpeed = _jogSpeed;
        }
        else
        {
            _animator.SetBool("IsCrouching", true);
            _isCrouching = true;
            _movementSpeed = _crouchSpeed;
        }
    }

    public void ToggleWalkAction()
    {
        if (_isWalkModeOn)
        {
            _animator.SetBool("IsWalkModeOn", false);
            _isWalkModeOn = false;
            _movementSpeed = _jogSpeed;
        }
        else
        {
            _animator.SetBool("IsWalkModeOn", true);
            _isWalkModeOn = true;
            _movementSpeed = _walkSpeed;
        }
    }
}
