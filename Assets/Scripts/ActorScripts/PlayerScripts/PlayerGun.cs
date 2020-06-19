using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject casingPrefab;
    public GameObject muzzleFlashPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;
    [SerializeField] private GameObject _impactEffect = default;
    [SerializeField] private EntityAudio _playerGunAudio = default;
    private readonly int _fireRange = 100;
    private readonly int _maxClipSize = 15;
    private int _currentClipSize = 15;


    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    public void Shoot()
    {
        if (_currentClipSize > 0)
        {
            _playerGunAudio.Play("Shot");
            Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, _fireRange);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Environment"))
                {
                    Instantiate(_impactEffect, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.FromToRotation(Vector3.up, hit.normal));
                }
            }
            GameObject tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
            CasingRelease();
            _currentClipSize--;
        }
        else
        {
            Reload();
        }
    }

    private void CasingRelease()
    {
        GameObject casing = Instantiate(casingPrefab, casingExitLocation.position, casingExitLocation.rotation);
        casing.GetComponent<Rigidbody>().AddExplosionForce(550f, (casingExitLocation.position - casingExitLocation.right * 0.3f - casingExitLocation.up * 0.6f), 1f);
        casing.GetComponent<Rigidbody>().AddTorque(new Vector3(0, Random.Range(100f, 500f), Random.Range(10f, 1000f)), ForceMode.Impulse);
    }

    private void Reload()
    {
        Debug.Log("reloading");
        _currentClipSize = _maxClipSize;
    }
}
