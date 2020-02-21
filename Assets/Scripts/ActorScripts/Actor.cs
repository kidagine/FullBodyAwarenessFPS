using UnityEngine;

[RequireComponent(typeof(Health))]
//[RequireComponent(typeof(Locomotive))]
abstract public class Actor : MonoBehaviour
{
    public Health Health { get; private set; }
    //public Locomotive Locomotive { get; private set; }
  
    public virtual void OnEnable()
    {
        Health = GetComponent<Health>();
        //Locomotive = GetComponent<Locomotive>();
    }

    public abstract void SetHealth();
}
