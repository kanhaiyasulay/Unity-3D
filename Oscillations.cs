using UnityEngine;

public class Oscillate : MonoBehaviour
{
    public float speed = 2f; // Speed of the oscillation
    public float distance = 3f; // Distance to move from the starting position

    private Vector3 startPosition;

    void Start()
    {
        // Record the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Oscillate along the X-axis
        float newX = startPosition.x + Mathf.PingPong(Time.time * speed, distance) - (distance / 2);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
