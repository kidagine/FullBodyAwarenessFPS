using TMPro;
using UnityEngine;

public class PlayerGunUI : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private GameObject _gunCanvas = default;
    [SerializeField] private TextMeshProUGUI _currentClipText = default;
    [SerializeField] private TextMeshProUGUI _totalAmmoText = default;
    [SerializeField] private TextMeshProUGUI _gunNameText = default;


    public void SetGunUI(bool enable, GunSO gunSO = default)
    {
        _gunCanvas.SetActive(enable);
        if (enable)
        {
            _animator.SetTrigger("ShowName");
            _gunNameText.text = gunSO.gunName;
            _currentClipText.text = gunSO.currentClipSize.ToString();
            _totalAmmoText.text = gunSO.totalAmmoAmount.ToString();
        }
    }

    public void SetGunName(string name)
    {
        _gunNameText.text = name;
    }

    public void SetCurrentClip(int amount)
    {
        _currentClipText.text = amount.ToString();
    }

    public void SetTotalAmmo(int amount)
    {
        _totalAmmoText.text = amount.ToString();
    }
}
