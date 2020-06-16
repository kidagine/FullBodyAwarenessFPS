﻿using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private Transform _leftFoot = default;
    [SerializeField] private Transform _rightFoot = default;
    [SerializeField] private CharacterController _characterController = default;
    [SerializeField] private GameObject _camera = default;
    [SerializeField] private PlayerIKSystem _playerIKSystem = default;
    [SerializeField] private EntityAudio _playerAudio;
    [SerializeField] private LayerMask _environmentLayerMask = default;
    private readonly float _jumpHeight = 0.8f;
    private readonly float _joggingSpeed = 4.5f;
    private readonly float _walkSpeed = 2.0f;
    private readonly float _jumpSpeed = 1.3f;
    private readonly int _gravity = -20;
    private Vector3 _velocity;
    private Vector3 _lastPosition;
    private Vector3 _rightFootPosition;
    private Vector3 _leftFootPosition;
    private float _moveSpeed = 2.0f;
    private float _groundedRaycastSize = 0.5f;
    private float _xAxis;
    private float _yAxis;
    private bool _isJoggingOn;
    private bool isRightFootOnGround;
    private bool isLeftFootOnGround;

    public Vector3 Move { get; private set; }
    public Vector2 MovementInput { get; set; }
    public RaycastHit Hit { get; set; }
    public bool IsGrounded { get; set; }
    public bool LockMovement { get; set; }
    public bool IsRunning { get; private set; }
    public bool CanJump { get; set; } = true;


    void Update()
    {
        Movement();
        CheckGrounded();
        Gravity();
    }

    void LateUpdate()
    {
        //EdgeFalling();
    }

    private void Movement()
    {
        _xAxis = MovementInput.x;
        _yAxis = MovementInput.y;

        Move = transform.right * _xAxis + transform.forward * _yAxis;
        _characterController.Move(Move * _moveSpeed * Time.deltaTime);

        float dist = Vector3.Distance(_lastPosition, transform.position);
        if (dist > 0.01f)
        {
            _animator.SetFloat("VelocityX", Mathf.Round(_xAxis), 0.1f, Time.deltaTime);
            _animator.SetFloat("VelocityY", Mathf.Round(_yAxis), 0.1f, Time.deltaTime);
        }
        else
        {
            _animator.SetFloat("VelocityX", 0.0f, 0.1f, Time.deltaTime);
            _animator.SetFloat("VelocityY", 0.0f, 0.1f, Time.deltaTime);
        }
        _lastPosition = gameObject.transform.position;
    }

    private void CheckGrounded()
    {
        _rightFootPosition = _playerIKSystem.GetAdjustedFootTarget(HumanBodyBones.RightToes);
        _leftFootPosition = _playerIKSystem.GetAdjustedFootTarget(HumanBodyBones.LeftToes);
        isRightFootOnGround = IsFootGrounded(_rightFootPosition, ref _playerIKSystem._rightFootIKPosition, ref _playerIKSystem._rightFootIKRotation);
        isLeftFootOnGround = IsFootGrounded(_leftFootPosition, ref _playerIKSystem._leftFootIKPosition, ref _playerIKSystem._leftFootIKRotation);

        if (!isRightFootOnGround && !isLeftFootOnGround)
        {
            if (IsGrounded)
            {
                _animator.SetBool("IsFalling", true);
                _groundedRaycastSize = 0.2f;
                _moveSpeed = _jumpSpeed;
            }
            IsGrounded = false;
        }
        else if (_velocity.y < 0.0f)
        {
            if (!IsGrounded)
            {
                _animator.SetBool("IsFalling", false);
                _groundedRaycastSize = 0.5f;
                _moveSpeed = _walkSpeed;
            }
            _velocity.y = -2;
            IsGrounded = true;
        }
    }

    private bool IsFootGrounded(Vector3 footPosition, ref Vector3 footIKPosition, ref Quaternion footIKRotations)
    {
        footIKPosition = Vector3.zero;
        if (Physics.Raycast(footPosition, Vector3.down, out RaycastHit hit, _groundedRaycastSize, _environmentLayerMask))
        {
            footIKPosition = footPosition;
            footIKPosition.y = hit.point.y;
            footIKRotations = Quaternion.FromToRotation(Vector3.up, hit.normal) * transform.rotation;
            return true;
        }
        return false;
    }

    private void Gravity()
    {
        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (IsGrounded)
        {
            _animator.SetTrigger("Jump");
            CanJump = false;
            _groundedRaycastSize = 0.2f;
            _moveSpeed = _jumpSpeed;
            _velocity.y = Mathf.Sqrt(_jumpHeight * -1.0f * _gravity);
        }
    }

    public void Crouch()
    {

    }

    public void SetCrouch(bool isCrouching, float moveSpeed, InputAction.CallbackContext context = default)
    {

    }

    public void Prone()
    {

    }

    public void Slide()
    {

    }

    public void Run()
    {

    }

    public void StopRun()
    {

    }

    public void PauseRun()
    {

    }

    public void Footsteps()
    {
        if (Move != Vector3.zero)
        {
            _playerAudio.PlayRandomFromSoundGroup("Footsteps");
        }
    }

    public void SwitchWalkMode()
    {
        if (_isJoggingOn)
        {
            _isJoggingOn = false;
            _moveSpeed = _walkSpeed;
        }
        else
        {
            _isJoggingOn = true;
            _moveSpeed = _joggingSpeed;
        }
        _animator.SetBool("IsJogging", _isJoggingOn);
    }
}
