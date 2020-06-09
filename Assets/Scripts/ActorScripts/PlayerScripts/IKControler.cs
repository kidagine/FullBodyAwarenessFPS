using UnityEngine;

public class IKControler : MonoBehaviour
{
    [SerializeField] Player _playerScript;
    [SerializeField] Transform _headIKTarget;
    [SerializeField] Transform _bodyIKTarget;
    [SerializeField] Transform _rightArmIKTarget;
    [SerializeField] Transform _rightElbowIKHint;
    [SerializeField] Transform _leftArmIKTarget;
    [SerializeField] Transform _leftElbowIKHint;
    public bool _isIKActive = false;
    private readonly float _lookIKWeight = 1.0f;
    private readonly float _holsterBodyWeight = 0.03f;
    private readonly float _unholsterBodyWeight = 0.07f;
    private readonly float _holsterHeadWeight = 0.7f;
    private readonly float _unholsterHeadWeight = 0.5f;
    private readonly float _clampWeight = 1.0f;
    private Animator _animator;

    private Transform chest;
    public Transform target;
    public Transform staticTarget;

    public Vector3 offset;
    public GameObject _fpsCamera;
    public GameObject _thirdPersonCamera;

    void Start()
    {
        _animator = GetComponent<Animator>();
        chest = _animator.GetBoneTransform(HumanBodyBones.Head);
    }


    private void LateUpdate()
    {
        if (_fpsCamera.activeSelf)
        {
            chest.LookAt(target);
            chest.rotation *= Quaternion.Euler(offset);
        }
        else
        {
            chest.LookAt(null);
        }
    }

    void OnAnimatorIK(int layerIndex)
    {
        if (_isIKActive)
        {
            //if (!_playerScript.IsHolster)
            //{
            //    LookAtUnHolsterMode(layerIndex);
            //}
            //else
            //{
            //    LookAtHolsterMode(layerIndex);
            //}

            //if (_playerScript.HasPickable)
            //{
            //    HoldPickable(layerIndex);
            //}
        }
    }

    private void LookAtHolsterMode(int layerIndex)
    {
        if (_playerScript.IsGrounded)
        {
            if (layerIndex == 0)
            {
                if (_playerScript.Move.magnitude > 0.0f)
                {
                    _animator.SetLookAtWeight(_lookIKWeight, 0.0f, _holsterHeadWeight, 0.0f, _clampWeight);
                }
                else
                {
                    _animator.SetLookAtWeight(_lookIKWeight, _holsterBodyWeight, _holsterHeadWeight, 0.0f, _clampWeight);
                }
                _animator.SetLookAtPosition(_headIKTarget.position);
            }
        }
    }

    private void LookAtUnHolsterMode(int layerIndex)
    {
        if (layerIndex == 0)
        {
            _animator.SetLookAtWeight(_lookIKWeight, _unholsterBodyWeight, _unholsterHeadWeight, 0.0f, _clampWeight);
            _animator.SetLookAtPosition(_headIKTarget.position);
        }

        if (layerIndex == 1)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, _lookIKWeight);
            _animator.SetIKPosition(AvatarIKGoal.RightHand, _rightArmIKTarget.position);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, _lookIKWeight);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _rightArmIKTarget.rotation);

            _animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, _lookIKWeight);
            _animator.SetIKHintPosition(AvatarIKHint.RightElbow, _rightElbowIKHint.position);

            _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _leftArmIKTarget.position);
            _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _leftArmIKTarget.rotation);

            _animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, _lookIKWeight);
            _animator.SetIKHintPosition(AvatarIKHint.LeftElbow, _leftElbowIKHint.position);
        }
    }

    private void HoldPickable(int layerIndex)
    {
        if (layerIndex == 0)
        {
            _animator.SetLookAtWeight(_lookIKWeight, _unholsterBodyWeight, _holsterHeadWeight, 0.0f, _clampWeight);
            _animator.SetLookAtPosition(_headIKTarget.position);
        }

        if (layerIndex == 1)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _leftArmIKTarget.position);
            _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _leftArmIKTarget.rotation);
        }
    }
}
