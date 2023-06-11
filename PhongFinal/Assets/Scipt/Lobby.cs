using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Lobby : MonoBehaviourPunCallbacks
{
    public TMP_InputField createRoomTxt;
    public TMP_InputField joinRoomTxt;
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoomTxt.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomTxt.text);
    }
}
