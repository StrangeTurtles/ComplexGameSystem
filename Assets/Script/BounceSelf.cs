using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSelf : MonoBehaviour
{
    public float length = .1f;
    public float speed = 15;
    private Vector3 moveDirection;
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * length, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, length))
        { 
            if (hit.transform.gameObject.tag == "Bouncy")
            
            {
                Debug.Log("Bouncy Hit");
                moveDirection.y = speed;
            }
        }
        moveDirection.y -= 9.8f * Time.deltaTime;
        GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);

    }
    #endregion
}
