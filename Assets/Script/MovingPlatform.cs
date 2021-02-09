using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    #region public field
    public  List<Transform> Nodes;
    public float speed = 5f;
    #endregion
    #region private field
    private int currentNode = 0;
    private Vector3 movement;
    #endregion
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        if(Nodes == null)
        {
            Debug.Log("Nodes are empty. Fill the Nodes list and try again");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Nodes != null)
        {
            //Nodes[currentNode]
            if(gameObject.transform.position  == Nodes[currentNode].position)
            {
                currentNode++;
                if(currentNode >= Nodes.Count)
                {
                    currentNode = 0;
                }
            }
            else
            {
                movement = Nodes[currentNode].position - gameObject.transform.position;
                //transform.position += movement * (speed * Time.deltaTime);
                transform.Translate(movement * (speed * Time.deltaTime));
            }
        }
    }
    #endregion
}
