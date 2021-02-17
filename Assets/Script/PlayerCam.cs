using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCam : MonoBehaviour
{
    private CinemachineVirtualCamera camera = null;
    // Start is called before the first frame update
    void Start()
    {
        camera = FindObjectOfType<CinemachineVirtualCamera>();
        camera.Follow = this.gameObject.transform;
        camera.LookAt = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
