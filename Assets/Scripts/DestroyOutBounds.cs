
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float topBound = 33.0f;
    private float lowerBound = -17.0f;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
