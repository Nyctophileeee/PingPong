using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Paddle : MonoBehaviour
{
    public float speed = 5;
    PhotonView pView;
    void Start()
    {
        Spawner.isPlayer1Exist = true;
        pView = this.gameObject.GetComponent<PhotonView>();
    }
    void Update()
    {
        if (pView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1 * speed);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * speed);
            }
        }
    }
}
