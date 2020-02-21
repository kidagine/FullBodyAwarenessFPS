using UnityEngine;

public class ExplosiveRound : RevolverRound
{
    private readonly int _attackDamage = 20;
    private readonly int _explosionRadius = 3;
    private readonly int _explosionForce = 600;
    private readonly bool _isRaycast = false;


    public override bool IsRaycast()
    {
        return _isRaycast;
    }

    public override void Action()
    {
        Explode();
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _explosionRadius);

        foreach (Collider impactedObject in colliders)
        {
            Health health = impactedObject.GetComponent<Health>();
            Rigidbody rigidbody = impactedObject.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
            }
            if (health != null)
            {
                health.ApplyDamage(_attackDamage);
            }
        }
    }
}
