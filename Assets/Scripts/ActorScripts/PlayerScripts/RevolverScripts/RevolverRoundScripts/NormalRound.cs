public class NormalRound : RevolverRound
{
    private readonly bool _isRaycast = true;


    public override bool IsRaycast()
    {
        return _isRaycast;
    }
}
