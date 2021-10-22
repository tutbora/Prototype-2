
using UnityEngine;

public class DestroyOutBoundsR : MonoBehaviour
{
    private float rightBound = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.x < -rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound - 2)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
