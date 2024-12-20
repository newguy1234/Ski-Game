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
        if (Input.GetKeyDown(KeyCode.A))
        {
            CharacterMove(AvailablePositions[0]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            CharacterMove(AvailablePositions[1]);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            CharacterMove(AvailablePositions[2]);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            CharacterMove(AvailablePositions[3]);
        }
    }
}
