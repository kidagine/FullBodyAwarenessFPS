using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerIK : MonoBehaviour
{
    [SerializeField] private Transform _lookAtTarget;
    private Transform _head;
    private Animator _animator;



    [Range(0, 2)] [SerializeField] private float _groundRaycast = 1.14f;
    [Range(0, 1)] [SerializeField] private float _pelvisUpAndDownSpeed = 0.28f;
    [Range(0, 1)] [SerializeField] private float _feetToIKPositionSpeed = 0.5f;
    private Vector3 _rightFootPosition;
    private Vector3 _leftFootPosition;
    public Vector3 _rightFootIKPosition;
    public Vector3 _leftFootIKPosition;
    public Quaternion _rightFootIKRotation;
    public Quaternion _leftFootIKRotation;
    private float _lastPelvisPositionY;
    private float _lastRightFootPositionY;
    private float _lastLeftFootPositionY;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _head = _animator.GetBoneTransform(HumanBodyBones.Head);
    }

    void LateUpdate()
    {
        if (_lookAtTarget.gameObject.activeInHierarchy)
        {
            _head.LookAt(_lookAtTarget);
        }
    }

    public Vector3 GetAdjustedFootTarget(HumanBodyBones foot)
    {
        Vector3 footPosition = _animator.GetBoneTransform(foot).position;
        footPosition.y = transform.position.y + _groundRaycast;
        return footPosition;
    }

    void OnAnimatorIK(int layerIndex)
    {
        if (layerIndex == 0)
        {
            AdjustPelvisHeight();
            MoveFootToIKPoint(AvatarIKGoal.RightFoot, _rightFootIKPosition, _rightFootIKRotation, ref _lastRightFootPositionY);
            MoveFootToIKPoint(AvatarIKGoal.LeftFoot, _leftFootIKPosition, _leftFootIKRotation, ref _lastLeftFootPositionY);

            _animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1.0f);
            _animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1.0f);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1.0f);
            _animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1.0f);
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

    private void MoveFootToIKPoint(AvatarIKGoal foot, Vector3 positionIKHolder, Quaternion rotationIKHolder, ref float lastFootPositionY)
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
