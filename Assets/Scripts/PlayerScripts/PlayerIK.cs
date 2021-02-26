using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerIK : MonoBehaviour
{
    [SerializeField] private Transform _lookAtTarget;
    private Transform _head;
    private Animator _animator;


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
}
