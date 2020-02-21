using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [HideInInspector] public UnityEvent OnDeath;
    private Rigidbody _rigidbody;

    public int MaxHealth { get; set; }
    public int MinimumMassMultiplier { get; set; }


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ApplyDamage(int damageAmount)
    {
        if (MaxHealth == 0)
        {
            Destroy(gameObject);
        }

        MaxHealth -= damageAmount;
        if (MaxHealth <= 0)
        {
            OnDeath.Invoke();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        Rigidbody rigidbody = other.collider.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            if (rigidbody.mass > _rigidbody.mass * MinimumMassMultiplier && rigidbody.velocity.magnitude > 5.0f)
            {
                OnDeath.Invoke();
            }
        }
    }
}
