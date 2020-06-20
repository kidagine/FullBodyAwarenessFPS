using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject casingPrefab;
    public Transform barrelLocation;
    public Transform casingExitLocation;
    [SerializeField] private GameObject muzzleFlashPrefab = default;
    [SerializeField] private GameObject _impactEffect = default;
    [SerializeField] private Camera _camera = default;
    [SerializeField] private PlayerUI _playerUI = default;
    [SerializeField] private EntityAudio _playerGunAudio = default;
    private readonly int _fireRange = 100;
    private readonly int _maxClipSize = 15;
    private int _totalAmmoAmount = 20;
    private int _currentClipSize = 15;


    void Start()
    {
        _playerUI.PlayerGunUI.SetCurrentClip(_currentClipSize);
        _playerUI.PlayerGunUI.SetTotalAmmo(_totalAmmoAmount);
        if (barrelLocation == null)
            barrelLocation = transform;
    }

    public void Shoot()
    {
        if (_currentClipSize > 0)
        {
            _playerGunAudio.Play("Shot");
            Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hit, _fireRange);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Environment"))
                {
                    Instantiate(_impactEffect, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                }
            }
            Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);
            CasingRelease();
            _currentClipSize--;
            _playerUI.PlayerGunUI.SetCurrentClip(_currentClipSize);
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

    public void Reload()
    {
    

        if (_totalAmmoAmount != 0)
        {
            int clipToLoad = _maxClipSize - _currentClipSize;
            if (_totalAmmoAmount >= clipToLoad)
            {
                _currentClipSize += clipToLoad;
                _totalAmmoAmount -= clipToLoad;
                _playerUI.PlayerGunUI.SetCurrentClip(_currentClipSize);
                _playerUI.PlayerGunUI.SetTotalAmmo(_totalAmmoAmount);
            }
            else
            {
                clipToLoad = _totalAmmoAmount;
                _currentClipSize += clipToLoad;
                _totalAmmoAmount -= clipToLoad;
                _playerUI.PlayerGunUI.SetCurrentClip(_currentClipSize);
                _playerUI.PlayerGunUI.SetTotalAmmo(_totalAmmoAmount);
            }
        }
    }
}
