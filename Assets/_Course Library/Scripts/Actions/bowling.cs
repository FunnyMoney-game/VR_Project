using UnityEngine;

public class bowling : MonoBehaviour

{
    [SerializeField] private GameObject scoreboard;
    private int scoreToAdd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("box"))
        {
            // Reset the ball's position

            // Reset velocity and rotation
        }
    }
}
