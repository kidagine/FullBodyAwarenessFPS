using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damageAmount);
    int GetHealth();
}