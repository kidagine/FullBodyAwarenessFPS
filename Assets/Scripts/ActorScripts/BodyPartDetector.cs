using UnityEngine;

public enum BodyPart { Head, Chest, Legs };
public class BodyPartDetector : MonoBehaviour, IDamageable
{
    [SerializeField] private DummyTarget _dummyTarget = default;
    [SerializeField] private BodyPart _bodyPart = default;


    public int GetHealth()
    {
        return _dummyTarget.GetHealth();
    }

    public void TakeDamage(int damageAmount)
    {
        int multipliedDamage = GetBodyPartHitDamage(damageAmount);
        _dummyTarget.TakeDamage(multipliedDamage);
    }
    
    private int GetBodyPartHitDamage(int damageAmount)
    {
        int multipliedDamage = damageAmount;
        switch (_bodyPart)
        {       
            case BodyPart.Head:
                multipliedDamage *= 3;
                break;
            case BodyPart.Chest:
                multipliedDamage *= 2;
                break;
            case BodyPart.Legs:
                multipliedDamage *= 1;
                break;
        }
        return multipliedDamage;
    }
}
