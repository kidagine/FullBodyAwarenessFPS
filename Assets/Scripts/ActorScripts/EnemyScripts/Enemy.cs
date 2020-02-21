using System.Collections;
using UnityEngine;

public class Enemy : Actor
{
    public Transform _test;
    public Transform _object;
    [SerializeField] private Animator _enemyAnimator;


    void Start()
    {
        SetHealth();
        SetRigidbodyState(true);
        SetColliderState(false);
    }

    void OnAnimatorIK()
    {
        _enemyAnimator.SetLookAtWeight(1);
        _enemyAnimator.SetLookAtPosition(_object.transform.position);

        _enemyAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        _enemyAnimator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        _enemyAnimator.SetIKPosition(AvatarIKGoal.LeftHand, _test.position);
        _enemyAnimator.SetIKRotation(AvatarIKGoal.LeftHand, _test.rotation);
    }

    public override void SetHealth()
    {
        Health.OnDeath.AddListener(Die);
        Health.MaxHealth = 10;
        Health.MinimumMassMultiplier = 2;
    }

    private void Die()
    { 
        StartCoroutine(testc());
    }

    IEnumerator testc()
    {
        _enemyAnimator.enabled = false;
        AudioManager.Instance.Play("Kill");
        yield return new WaitForSeconds(0.11f);
        SetRigidbodyState(false);
        SetColliderState(true);
    }

    private void SetRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;
    }

    private void SetColliderState(bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }

        GetComponent<Collider>().enabled = !state;
    }
}
