using UnityEngine;

public class RevolverRound : MonoBehaviour
{
    public virtual bool IsRaycast()
    {
        return true;
    }

    public virtual void Action(){}
}
