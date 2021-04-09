using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Com.MyCompany.MyGame;

public class PlayerCam : MonoBehaviour
{
    private CinemachineVirtualCamera _camera = null;
    GameManager gameManager;
    [HideInInspector]
    public GameObject playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _camera = FindObjectOfType<CinemachineVirtualCamera>();
        gameManager = FindObjectOfType<GameManager>();
        _camera.Follow = playerTransform.transform;
        _camera.LookAt = playerTransform.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
