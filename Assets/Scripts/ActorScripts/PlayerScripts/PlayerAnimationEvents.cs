using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerMovement _playerMovement = default;
    [SerializeField] private EntityAudio _playerAudio = default;
    [SerializeField] private Animator _animator = default;

    public void EnableShoot()
    {
        _player.CanShoot = true;
    }

    public void DisableShoot()
    {
        _player.CanShoot = false;
    }

    public void EnableAnyState()
    {
        _animator.SetBool("StopAnyState", false);
    }

    public void DisableAnyState()
    {
        _animator.SetBool("StopAnyState", true);
    }

    public void EnableJump()
    {
        _playerMovement.CanJump = true;
    }

    public void EnableMovement()
    {
        _player.LockMovement = false;
    }

    public void DisableMovement()
    {
        _player.LockMovement = true;
    }

    public void EnableSlowdown()
    {
        Time.timeScale = 0.5f;
    }

    public void DisableSlowdown()
    {
        Time.timeScale = 1.0f;
    }

    public void PlayFootstepAnimationEvent()
    {
        _playerMovement.Footsteps();
    }
}
