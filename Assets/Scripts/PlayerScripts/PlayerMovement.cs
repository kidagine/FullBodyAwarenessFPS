using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerCamera))]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerFPSMovement))]
[RequireComponent(typeof(PlayerThirdPersonMovement))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0.0f, 7.0f)]
    [SerializeField] private float _walkSpeed = 5.0f;
    [Range(0.0f, 10.0f)]
    [SerializeField] private float _jogSpeed = 7.0f;
    [Range(0.0f, 12.0f)]
    [SerializeField] private float _sprintSpeed = 10.0f;
    private Animator _animator;
    private CharacterController _characterController;
    private PlayerCamera _playerCamera;
    private PlayerFPSMovement _playerFPSMovement;
    private PlayerThirdPersonMovement _playerThirdPersonMovement;
    private float _movementSpeed;
    private bool _isWalkModeOn;

    public Vector3 MovementVector { get; private set; }
    public Vector2 MovementInput { private get; set; }


    void Awake()
    {
        _animator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();
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
    }

    public void SprintAction()
    {
        _animator.SetBool("IsSprinting", true);
        _movementSpeed = _sprintSpeed;
    }

    public void ToggleCrouchAction()
    {
        //_animator.SetBool("IsCrouching", true);
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
