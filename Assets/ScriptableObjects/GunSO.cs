
using UnityEngine;

[CreateAssetMenu(fileName = "GunSO", menuName = "ScriptableObjects/GunSO")]
public class GunSO : ScriptableObject
{
    public string gunName;
    public Sprite gunIcon;
    public int currentClipSize;
    public int maxClipSize;
    public int totalAmmoAmount;
}