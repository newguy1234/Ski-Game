using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private bool isSwiping = false;
    [SerializeField] private Vector2 startTouchPosition, endTouchPosition;
    private int currentLane = 1; // Start in the middle lane (index 1)
    [SerializeField] private readonly float[] lanes = { -2f, 0f, 2f }; // Define x-coordinates for lanes
    private float moveSpeed = 10f; // Speed to move between lanes

    void MovePlayer()
    {
        Vector3 targetPosition = new Vector3(lanes[currentLane], transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleSwipe();
        MovePlayer();
    }
    private void HandleSwipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
            isSwiping = true;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Ended && isSwiping)
        {
            endTouchPosition = Input.GetTouch(0).position;
            isSwiping = false;
            DetectSwipe();
        }
    }
    private void DetectSwipe()
    {
        Vector2 swipeDelta = endTouchPosition - startTouchPosition;
        if (Mathf.Abs(swipeDelta.x) > (Mathf.Abs(swipeDelta.y)))
        {
            if(swipeDelta.x > 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }
    }

    private void MoveRight()
    {
        if (currentLane < lanes.Length - 1) // Check bounds
        {
            currentLane++;
        }
    }

    private void MoveLeft()
    {
        if (currentLane > 0) // Check bounds
        {
            currentLane--;
        }
    }
}
