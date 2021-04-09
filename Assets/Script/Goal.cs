using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Com.MyCompany.MyGame;

public class Goal : MonoBehaviour
{
    GameManager gameManager;
    bool active = false;
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            Debug.Log("active");
            //GameManager.Instance.LeaveRoom();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerManager>() != null)
        {
            GameManager.Instance.Winner = true;
            active = true;
            GameManager.Instance.LeaveRoom();
        }

    }
    #endregion
}
