using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private PlayerReticleUI _playerReticleUI = default;
    [SerializeField] private PlayerGunUI _playerGunUI = default;


    public PlayerReticleUI PlayerReticleUI { get { return _playerReticleUI; } private set { } }
    public PlayerGunUI PlayerGunUI { get { return _playerGunUI; } private set { } }
}
