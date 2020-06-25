using UnityEngine;

public class DummyTarget : MonoBehaviour, IDamageable
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private EntityAudio _dummyTargetAudio = default;
    private readonly int _maxHealth = 3;
    private int _currentHealth = 3;
    private bool _isDead;


    public int GetHealth()
    {
        return _currentHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        if (!_isDead)
        {
            _currentHealth -= damageAmount;
            if (_currentHealth <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        _animator.SetTrigger("Die");
        _dummyTargetAudio.Play("Die");
        _isDead = true;
    }

    public void ResetDie()
    {
        _isDead = false;
        _currentHealth = _maxHealth; 
    }
}
