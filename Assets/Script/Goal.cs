using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Com.MyCompany.MyGame;
using Photon.Realtime;
using Photon.Pun;
using ExitGames.Client.Photon;

public class Goal : MonoBehaviour
{
    GameManager gameManager;
    public const byte BootEveryOneEventCode = 1;
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerManager>() != null)
        {
            gameManager.Winner = true;
            RaiseEventOptions raiseEventOptions = new RaiseEventOptions { Receivers = ReceiverGroup.Others };
            bool kick = true;
            PhotonNetwork.RaiseEvent(BootEveryOneEventCode,kick,raiseEventOptions, SendOptions.SendReliable);
            GameManager.Instance.LeaveRoom();
        }

    }
    #endregion
}
