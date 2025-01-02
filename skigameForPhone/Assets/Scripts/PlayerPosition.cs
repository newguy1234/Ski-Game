using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public PlayerSpot[] AvailablePositions;
    public PlayerSpot CurrentPosition;
    [SerializeField] private PlayerSpot StartingPosition;
    private void Start()
    {
        CurrentPosition = StartingPosition;
        this.transform.position = CurrentPosition.transform.position;
        AvailablePositions = CurrentPosition.GetNeighbouringPositions();
    }
    void CharacterChangePosition()
    {
        this.transform.position = CurrentPosition.transform.position;
    }
    void CharacterMove(PlayerSpot nextPosition)
    {
        CurrentPosition = nextPosition;
        CharacterChangePosition();
        AvailablePositions = CurrentPosition.GetNeighbouringPositions();
    }

    private void Update()
    {
    }
}
