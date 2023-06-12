using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float initialSpeed = 100;
    public float speedIncrease = 10000;
    
    private int hitCounter;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2f);
    }
    void Update()
    {
        if (!PhotonNetwork.IsMasterClient) return;
    }

    void FixedUpdate() 
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, initialSpeed + (speedIncrease) * hitCounter);   
    }

    public void StartBall()
    {
        rb.velocity = new Vector2(-1,0) * (initialSpeed + speedIncrease * hitCounter); 
    }

    public void ResetBall()
    {
        rb.velocity = new Vector2(0,0);
        transform.position = new Vector2(0,0);
        hitCounter = 0;
        Invoke("StartBall", 2f);
    }

    public void PlayerBounce(Transform myObject)
    {
        hitCounter++;

        Vector2 ballPos = transform.position;
        Vector2 playerPos = myObject.position;

        float xDirection, yDirection;
        if(transform.position.x >0)
        {
            xDirection = -1;
        }
        else xDirection = 1;
        yDirection = (ballPos.y - playerPos.y) / myObject.GetComponent<Collider2D>().bounds.size.y;
        if(yDirection == 0)
        {
            yDirection = 0.25f;
        }
        rb.velocity = new Vector2(xDirection, yDirection) * (initialSpeed + (speedIncrease * hitCounter ));
    }

    public void OnCollionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Paddle")
        {
            PlayerBounce(collision.transform);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if(transform.position.x > 0)
        {
            ResetBall();
        }
        if(transform.position.x < 0)
        {
            ResetBall();
        }
    }


}
