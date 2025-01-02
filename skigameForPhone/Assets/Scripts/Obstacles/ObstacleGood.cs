using UnityEngine;

public class ObstacleGood : ObstacleBase
{
    [SerializeField] private IntEventChannel _intEventChannel;
    [SerializeField] private int _pointValue = 10;
    
    public override void OnCollide()
    {
        _intEventChannel.RaiseEvent(_pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnCollide();
            Destroy(this.gameObject);
        }
    }
}
