using UnityEngine;

public class ObstacleBad : ObstacleBase
{
    public override void OnCollide()
    {
        Destroy(this.gameObject);
    }
}

