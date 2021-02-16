using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSelf : MonoBehaviour
{
    public float length = 14;
    public float speed = 5;
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 5, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, length) && hit.transform.gameObject.tag == "Bouncy")
        {
            Debug.Log("hit");
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, length), transform.position.z);
        }
    }
    #endregion
}
