using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(RandomGenerator() * speed,  RandomGenerator() * speed);
    }
    void Update()
    {
        if (!PhotonNetwork.IsMasterClient) return;
    }

    public float RandomGenerator()
    {
        float random = Random.Range(0, 2) == 0 ? -1: 1;
        return random;
    }


}
