using UnityEngine;

public class PlayerSpot : MonoBehaviour
{
    public PlayerSpot[] NeighbouringSpots;

    private bool isOccupied;

    private void Start()
    {
        isOccupied = false;
    }

    public PlayerSpot[] GetNeighbouringPositions()
    {
        return NeighbouringSpots;
    }
}
