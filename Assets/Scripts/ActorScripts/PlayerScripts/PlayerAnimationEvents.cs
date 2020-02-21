using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Revolver _revolver;
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void EnableShoot()
    {
        _player.CanShoot = true;
    }

    public void DisableShoot()
    {
        _player.CanShoot = false;
    }

    public void EnableMovement()
    {
        _player.LockMovement = false;
    }

    public void DisableMovement()
    {
        _player.LockMovement = true;
    }

    public void EmptyCylinderEvent()
    {
        _revolver.EmptyCylinder();
    }

    public void EnableSlowdown()
    {
        Time.timeScale = 0.5f;
    }

    public void DisableSlowdown()
    {
        Time.timeScale = 1.0f;
    }
}
