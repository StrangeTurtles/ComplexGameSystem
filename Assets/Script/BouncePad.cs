using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public Vector3 movement;
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
        otherTransform = other.gameObject.transform;
        Debug.Log("Hit");
    }
    #endregion
}
