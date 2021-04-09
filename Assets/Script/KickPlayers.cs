using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
using Photon.Realtime;
using Photon.Pun;
using Com.MyCompany.MyGame;

public class KickPlayers : MonoBehaviour
{
    public const byte BootEveryOneEventCode = 1;
    private GameManager gameManager;
    private void OnEnable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
    }
    private void OnDisable()
    {
        PhotonNetwork.NetworkingClient.EventReceived -= OnEvent;
    }
    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnEvent(EventData photonEvent)
    {
        byte eventCode = photonEvent.Code;
        if(eventCode == BootEveryOneEventCode)
        {
            GameManager.Instance.LeaveRoom();
        }
    }
}
