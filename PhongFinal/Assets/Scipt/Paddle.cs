using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1 * speed);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * speed);
        }    
    }
}
