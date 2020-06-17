using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private Transform _gunHolsterPlacement = default;
    [SerializeField] private Transform _gunUnholsterPlacement = default;
    [SerializeField] private Transform _gun = default;

    public bool IsGunHolstered { get; private set; } = true;


    public void ToggleHolster()
    {
        if (!IsGunHolstered)
        {
            _gun.SetParent(_gunHolsterPlacement);
        }
        else
        {
            _gun.SetParent(_gunUnholsterPlacement);
        }
        _gun.localPosition = Vector3.zero;
        _gun.localRotation = Quaternion.identity;
        IsGunHolstered = !IsGunHolstered;
        _animator.SetBool("IsGunHolstered", IsGunHolstered);
    }
}