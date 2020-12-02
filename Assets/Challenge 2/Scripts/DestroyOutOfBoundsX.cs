using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy
        if (transform.position.x < leftLimit || transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        } 
    }
}
