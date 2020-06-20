using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float _destroyAfterTime = default;


    void Start()
    {
        Destroy(gameObject, _destroyAfterTime);    
    }
}
