using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject paddle;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(paddle.name, new Vector3(-9, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
