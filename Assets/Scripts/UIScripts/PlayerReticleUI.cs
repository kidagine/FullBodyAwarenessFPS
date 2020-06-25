using UnityEngine;

public class PlayerReticleUI : MonoBehaviour
{
    [SerializeField] private GameObject _gunReticle = default;
    [SerializeField] private GameObject _hit = default;
    [SerializeField] private GameObject _hitR = default;


    public void SetGunReticle(bool enable)
    {
        _gunReticle.SetActive(enable);
    }

    public void ShowHitCrosshair()
    {
        _hit.SetActive(true);
        Invoke("Test", 0.2F);
    }

    public void ShowKillCrosshair()
    {
        _hitR.SetActive(true);
        Invoke("Test", 0.2F);
    }

    void Test()
    {
        _hit.SetActive(false);
        _hitR.SetActive(false);
    }
}
