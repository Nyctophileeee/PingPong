using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviourPunCallbacks
{
    public TMP_InputField createRoomTxt;
    public TMP_InputField joinRoomTxt;
    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene(2);
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
