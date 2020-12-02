using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject food;

    public float horizontalInput;
    public float speed = 10.0f;
    public float xBounds = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this thing here will keep player from leaving the camera behind
        if (transform.position.x < -xBounds)
        {
            transform.position = new Vector3(-xBounds, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xBounds)
        {
            transform.position = new Vector3(xBounds, transform.position.y, transform.position.z);
        }
        //this thing here will move the player because standing still is tiring
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //to check space key press so player can throw food at animals
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }
    }
}
