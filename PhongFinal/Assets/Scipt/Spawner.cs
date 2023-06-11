using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject paddle;
    public static bool isPlayer1Exist = false;
    // Start is called before the first frame update
    void Start()
    {
        if(isPlayer1Exist == false)
        {
            PhotonNetwork.Instantiate(paddle.name, new Vector3(-8, 0, 0), Quaternion.identity);
        } else
        {
        PhotonNetwork.Instantiate(paddle.name, new Vector3(8, 0, 0), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
