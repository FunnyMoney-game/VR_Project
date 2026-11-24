
using UnityEngine;

public class reset : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private Vector3 originalPos;
    private Rigidbody rb;

    void Start()
    {
        // Get the ball's Rigidbody
        rb = ball.GetComponent<Rigidbody>();

        // Save the ball's starting position
        originalPos = ball.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            // Reset the ball's position
            ball.transform.position = originalPos;

            // Reset velocity and rotation
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}