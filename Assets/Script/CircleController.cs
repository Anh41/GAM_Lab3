using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circlecontroller : MonoBehaviour
{
    // Start is called before the first frame update
   
    private int direction = 1;
    private float moveSpeed = 3;
    private void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        if (transform.position.y>= 1.74f||transform.position.y<= -0.77f)
        {
            direction *= -1;
        }
    }
}
