using UnityEngine;

public class MoverAndDead : MonoBehaviour
{
    // Speed of the object
    public float moveSpeed = 5f;

    // Lifetime of the object
    public float lifetime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy the object after 'lifetime' seconds
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
