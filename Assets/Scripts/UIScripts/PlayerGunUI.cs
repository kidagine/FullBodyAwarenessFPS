using TMPro;
using UnityEngine;

public class PlayerGunUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentClipText = default;
    [SerializeField] private TextMeshProUGUI _totalAmmoText = default;


    public void SetCurrentClip(int amount)
    {
        _currentClipText.text = amount.ToString();
    }

    public void SetTotalAmmo(int amount)
    {
        _totalAmmoText.text = amount.ToString();
    }
}
