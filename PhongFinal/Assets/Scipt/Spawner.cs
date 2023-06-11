using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject paddle;
    public static bool isPlayer1Exist = false;

    void Start()
    {
        if (isPlayer1Exist == false)
        {
            Vector3 spawnPosition = new Vector3(8, 0, 0);
            PhotonNetwork.Instantiate(paddle.name, spawnPosition, Quaternion.identity);
        }
        else
        {
            Vector3 spawnPosition = new Vector3(-8, 0, 0);
            if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
                spawnPosition.x *= -1;
            }
            PhotonNetwork.Instantiate(paddle.name, spawnPosition, Quaternion.identity);
        }
        
    }
}