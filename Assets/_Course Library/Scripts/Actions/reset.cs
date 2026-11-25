
using UnityEngine;

public class reset : MonoBehaviour
{

    private Vector3 originalPos;
    private Rigidbody rb;

    void Start()
    {

        // Save the ball's starting position
        originalPos = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            // Reset the ball's position
            transform.position = originalPos;

            // Reset velocity and rotation
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        if (other.CompareTag("Goal"))
        {
            // Reset the ball's position
            transform.position = originalPos;
            FindFirstObjectByType<ScoreManager>().AddScore(10);

        }
    }
}