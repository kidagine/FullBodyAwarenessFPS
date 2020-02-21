using System.Collections.Generic;
using UnityEngine;

public class Revolver : MonoBehaviour
{
    [SerializeField] private Animator _killDotAnimator;
    [SerializeField] private Animator _animator;
    [SerializeField] private ParticleSystem _muzzleFlash;
    [SerializeField] private Transform _playerCamera;
    [SerializeField] private GameObject _killDot;
    [SerializeField] private GameObject _impactEffect;
    [SerializeField] private GameObject _revolverFirePoint;
    [SerializeField] private GameObject _cylinder;
    [SerializeField] private List<RevolverRound> _revolverRounds;
    private readonly int _cylinderSize = 6;
    private readonly int _fireRange = 100;
    private readonly int _impactForce = 200;
    private int _currentRoundIndex = 0;


    private void LateUpdate()
    {
        //transform.position = _playerCamera.position;
        //transform.rotation = _playerCamera.rotation;
    }

    public void Shoot()
    {
        //if (!IsChamberEmpty())
        //{
        //    AudioManager.Instance.Play("RevolverShot");
        //    _muzzleFlash.Play();

        //    Physics.Raycast(_revolverFirePoint.transform.position, _revolverFirePoint.transform.forward, out RaycastHit hit, _fireRange);
        //    if (hit.collider != null)
        //    {
        //        Health health = hit.collider.GetComponent<Health>();
        //        Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();

        //        if (rigidbody != null)
        //        {
        //            rigidbody.AddForce(-hit.normal * _impactForce);
        //        }
        //        if (health != null)
        //        {
        //            _killDotAnimator.SetTrigger("Kill");
        //            _killDot.transform.position = Camera.main.WorldToScreenPoint(hit.point);
        //            health.ApplyDamage(10);
        //        }
        //        else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Environment"))
        //        {
        //            Instantiate(_impactEffect, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.FromToRotation(Vector3.up, hit.normal));
        //        }

        //        if (!_revolverRounds[_currentRoundIndex].IsRaycast())
        //        {
        //            GameObject revolverRound = Instantiate(_revolverRounds[_currentRoundIndex].gameObject, new Vector3(hit.point.x + 0.1f, hit.point.y + 0.1f, hit.point.z + 0.1f), Quaternion.FromToRotation(Vector3.up, hit.normal));
        //            revolverRound.GetComponent<RevolverRound>().Action();
        //        }
        //    }
        //    RemoveRoundBullet();
        //}
        //else
        //{
        //    AudioManager.Instance.Play("RevolverDry");
        //}
        //_revolverRounds[_currentRoundIndex] = null;
        //NextChamber();
        AudioManager.Instance.Play("RevolverShot");
        _animator.SetTrigger("Fire");
        _muzzleFlash.Play();

        Physics.Raycast(_revolverFirePoint.transform.position, _revolverFirePoint.transform.forward, out RaycastHit hit, _fireRange);
        if (hit.collider != null)
        {
            Health health = hit.collider.GetComponent<Health>();
            Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                rigidbody.AddForce(-hit.normal * _impactForce);
            }
            if (health != null)
            {
                _killDotAnimator.SetTrigger("Kill");
                _killDot.transform.position = Camera.main.WorldToScreenPoint(hit.point);
                health.ApplyDamage(10);
            }
            else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Environment"))
            {
                Instantiate(_impactEffect, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.FromToRotation(Vector3.up, hit.normal));
            }
        }
    }

    public bool IsChamberEmpty()
    {
        if (_revolverRounds[_currentRoundIndex] == null)
        {
            return true;
        }
        return false;
    }

    private void NextChamber()
    {
        if (_currentRoundIndex + 1 < _cylinderSize)
        {
            _currentRoundIndex++;
        }
        else
        {
            _currentRoundIndex = 0;
        }
    }

    public void AddRound(GameObject round)
    {
        RevolverRound revolverRound = round.GetComponent<RevolverRound>();
        Transform currentChamber = _cylinder.transform.GetChild(_currentRoundIndex);
        if (currentChamber.transform.childCount > 0)
        {
            GameObject currentRound = currentChamber.GetChild(0).gameObject;
            Destroy(currentRound);
        }

        _revolverRounds[_currentRoundIndex] = revolverRound;
        GameObject roundPrefab = Instantiate(round, currentChamber.position, Quaternion.identity);
        roundPrefab.transform.SetParent(currentChamber);
        NextChamber();
    }

    private void RemoveRoundBullet()
    {
        Transform currentChamber = _cylinder.transform.GetChild(_currentRoundIndex);
        Transform currentRound = currentChamber.GetChild(0);
        GameObject currentBullet = currentRound.GetChild(0).gameObject;
        Destroy(currentBullet);
    }

    public void EmptyCylinder()
    {
        for (int i = 0; i < _cylinder.transform.childCount; i++)
        {
            Transform currentChamber = _cylinder.transform.GetChild(i);
            if (currentChamber.childCount > 0)
            {
                GameObject currentRound = currentChamber.GetChild(0).gameObject;
                currentRound.transform.SetParent(null);
                currentRound.GetComponent<Rigidbody>().isKinematic = false;
                Destroy(currentRound, 1.0f);
            }
        }
    }
}
