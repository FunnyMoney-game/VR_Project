
using UnityEngine;

public class CanKnockOver : MonoBehaviour
{
    private bool isKnockedOver = false;

    void Update()
    {
        float angle = Vector3.Angle(
            transform.up,
            Vector3.up
        );

        if (angle > 45f && !isKnockedOver)
        {
            isKnockedOver = true;
            OnKnockedOver();
        }
    }

    void OnKnockedOver()
    {
        Debug.Log("Can knocked over!");
        FindFirstObjectByType<ScoreManager>().AddScore(10);

        // Put your scoring code here
    }
}