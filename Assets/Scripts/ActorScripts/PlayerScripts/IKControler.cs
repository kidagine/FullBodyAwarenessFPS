using UnityEngine;

public class IKControler : MonoBehaviour
{
    [SerializeField] private Player _player = default;
    [SerializeField] private Animator _animator = default;
    [SerializeField] Transform _headIKTarget;
    [SerializeField] Transform _bodyIKTarget;
    [SerializeField] Transform _rightArmIKTarget;
    [SerializeField] Transform _rightElbowIKHint;
    [SerializeField] Transform _leftArmIKTarget;
    [SerializeField] Transform _leftElbowIKHint;
    public bool _isIKActive = false;
    private readonly float _lookIKWeight = 1.0f;
    private readonly float _holsterBodyWeight = 0.03f;
    private readonly float _unholsterBodyWeight = 0.5f;
    private readonly float _holsterHeadWeight = 0.7f;
    private readonly float _unholsterHeadWeight = 0.5f;
    private readonly float _clampWeight = 1.0f;

    public Transform target;
    public Transform staticTarget;


    void OnAnimatorIK(int layerIndex)
    {
        if (layerIndex == 0)
        {
            if (_isIKActive)
            {
                if (!_player.IsGunHolstered)
                {
                    LookAtUnHolsterMode(layerIndex);
                }
                else
                {
                    LookAtHolsterMode(layerIndex);
                }
            }
        }
    }

    private void LookAtHolsterMode(int layerIndex)
    {
        //if (_playerScript.Move.magnitude > 0.0f)
        //{
        //    _animator.SetLookAtWeight(_lookIKWeight, 0.0f, _holsterHeadWeight, 0.0f, _clampWeight);
        //}
        //else
        //{
        //    _animator.SetLookAtWeight(_lookIKWeight, _holsterBodyWeight, _holsterHeadWeight, 0.0f, _clampWeight);
        //}
        //_animator.SetLookAtPosition(_headIKTarget.position);
    }

    private void LookAtUnHolsterMode(int layerIndex)
    {
        _animator.SetLookAtWeight(_lookIKWeight, _unholsterBodyWeight, _unholsterHeadWeight, 0.0f, _clampWeight);
        _animator.SetLookAtPosition(_headIKTarget.position);

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
