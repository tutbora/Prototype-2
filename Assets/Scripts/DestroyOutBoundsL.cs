
using UnityEngine;

public class DestroyOutBoundsL : MonoBehaviour
{
    private float leftBound = 40.0f;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.x > leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -leftBound + 2)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
