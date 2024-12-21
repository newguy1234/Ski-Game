using UnityEngine;

public class ObstacleGood : ObstacleBase
{
    [SerializeField] private IntEventChannel _intEventChannel;
    [SerializeField] private int _pointValue;
    
    public override void OnCollide()
    {
        _intEventChannel.RaiseEvent(_pointValue);
    }
}
