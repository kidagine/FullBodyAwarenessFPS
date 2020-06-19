using UnityEngine;

public class PlayerReticleUI : MonoBehaviour
{
    [SerializeField] private GameObject _gunReticle = default;


    public void SetGunReticle(bool enable)
    {
        _gunReticle.SetActive(enable);
    }
}
