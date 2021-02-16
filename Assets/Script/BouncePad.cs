using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public Vector3 movement;
    public float length = 14;
    public float speed = 1;
    private Transform otherTransform;
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //otherTransform.position += movement;
    }
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, 14) , transform.position.z);
    }
    #endregion
}
