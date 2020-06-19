using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private PlayerReticleUI _playerReticleUI = default;


    public PlayerReticleUI PlayerReticleUI { get { return _playerReticleUI; } private set { } }
}
