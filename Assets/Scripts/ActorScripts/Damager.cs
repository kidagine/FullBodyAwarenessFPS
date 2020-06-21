using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private LayerMask _damageableLayer = default;
    public int _damageAmount = default;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.gameObject.layer) & _damageableLayer) != 0)
        {
            if (collision.gameObject.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(_damageAmount);
            }
        }
    }
}