using UnityEngine;

public class PlayerIKSystem : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private LayerMask _environmentLayer;
    [SerializeField] private PlayerMovement _playerMovement;
    [Range(0, 2)] [SerializeField] private float _groundRaycast = 1.14f;
    [Range(0, 2)] [SerializeField] private float _raycastDownDistance = 1.5f;
    [Range(0, 1)] [SerializeField] private float _pelvisUpAndDownSpeed = 0.28f;
    [Range(0, 1)] [SerializeField] private float _feetToIKPositionSpeed = 0.5f;
    private Vector3 _rightFootPosition;
    private Vector3 _leftFootPosition;
    private Vector3 _rightFootIKPosition;
    private Vector3 _leftFootIKPosition;
    private Quaternion _rightFootIKRotation;
    private Quaternion _leftFootIKRotation;
    private float _lastPelvisPositionY;
    private float _lastRightFootPositionY;
    private float _lastLeftFootPositionY;
    private int _foot;

    private void FixedUpdate()
    {
        _rightFootPosition = GetAdjustedFootTarget(HumanBodyBones.RightFoot);
        _leftFootPosition = GetAdjustedFootTarget(HumanBodyBones.LeftFoot);

        bool isRightFootOnGround = false;
        bool isLeftFootOnGround = false;
        if (!_playerMovement.Stop)
        {
            isRightFootOnGround = FootPositionSolver(_rightFootPosition, ref _rightFootIKPosition, ref _rightFootIKRotation);
            isLeftFootOnGround = FootPositionSolver(_leftFootPosition, ref _leftFootIKPosition, ref _leftFootIKRotation);
        }

        if (isRightFootOnGround || isLeftFootOnGround)
        {
            _playerMovement.IsGrounded = true;
        }
        else
        {
            _playerMovement.IsGrounded = false;
        }
    }

    private Vector3 GetAdjustedFootTarget(HumanBodyBones foot)
    {
        Vector3 footPosition = _animator.GetBoneTransform(foot).position;
        footPosition.y = transform.position.y + _groundRaycast;
        return footPosition;
    }

    private bool FootPositionSolver(Vector3 footPosition, ref Vector3 footIKPosition, ref Quaternion footIKRotations)
    {
        bool isFootOnGround;
        if (Physics.Raycast(footPosition, Vector3.down, out RaycastHit hit, _raycastDownDistance + _groundRaycast, _environmentLayer))
        {
            footIKPosition = footPosition;
            footIKPosition.y = hit.point.y;
            footIKRotations = Quaternion.FromToRotation(Vector3.up, hit.normal) * transform.rotation;
            isFootOnGround = true;
        }
        else
        {
            footIKPosition = Vector3.zero;
            isFootOnGround = false;
        }
        return isFootOnGround;
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (layerIndex == 0)
        {
            if (!_playerMovement.Stop && _playerMovement.IsGrounded)
            {
                AdjustPelvisHeight();
                MoveFootToIKPoint(AvatarIKGoal.RightFoot, _rightFootIKPosition, _rightFootIKRotation, ref _lastRightFootPositionY);
                MoveFootToIKPoint(AvatarIKGoal.LeftFoot, _leftFootIKPosition, _leftFootIKRotation, ref _lastLeftFootPositionY);

                _animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1.0f);
                _animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1.0f);
                _animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, _animator.GetFloat("RightFootCurve"));
                _animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, _animator.GetFloat("LeftFootCurve"));
            }

        }
    }

    private void AdjustPelvisHeight()
    {
        if (_rightFootIKPosition == Vector3.zero || _leftFootIKPosition == Vector3.zero || _lastPelvisPositionY == 0.0f)
        {
            _lastPelvisPositionY = _animator.bodyPosition.y;
        }
        else
        {
            float leftFootOffset = _leftFootIKPosition.y - transform.position.y;
            float rightFootOffset = _rightFootIKPosition.y - transform.position.y;
            float totalOffset = (leftFootOffset < rightFootOffset) ? leftFootOffset : rightFootOffset;

            Vector3 pelvisPosition = _animator.bodyPosition + Vector3.up * totalOffset;
            pelvisPosition.y = Mathf.Lerp(_lastPelvisPositionY, pelvisPosition.y, _pelvisUpAndDownSpeed);
            _animator.bodyPosition = pelvisPosition;
            _lastPelvisPositionY = _animator.bodyPosition.y;
        }
    }

    void MoveFootToIKPoint(AvatarIKGoal foot, Vector3 positionIKHolder, Quaternion rotationIKHolder, ref float lastFootPositionY)
    {
        Vector3 targetIKPosition = _animator.GetIKPosition(foot);

        if (positionIKHolder != Vector3.zero)
        {
            targetIKPosition = transform.InverseTransformPoint(targetIKPosition);
            positionIKHolder = transform.InverseTransformPoint(positionIKHolder);

            float ratioY = Mathf.Lerp(lastFootPositionY, positionIKHolder.y, _feetToIKPositionSpeed);
            targetIKPosition.y += ratioY;
            lastFootPositionY = ratioY;
            targetIKPosition = transform.TransformPoint(targetIKPosition);
            _animator.SetIKRotation(foot, rotationIKHolder);
        }
        _animator.SetIKPosition(foot, targetIKPosition);
    }
}