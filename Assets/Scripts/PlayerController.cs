using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalXInput;
    private float verticalZInput;
    public float speed;
    public float xRange;
    public float zRange;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        horizontalXInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalXInput * Time.deltaTime * speed);

        verticalZInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalZInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

}
