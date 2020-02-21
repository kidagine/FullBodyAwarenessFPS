using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject _camera;


    void Update()
    {
        transform.rotation = _camera.transform.rotation;
    }
}
