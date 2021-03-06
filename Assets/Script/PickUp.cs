﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    #region public fields
    public enum PICKUPTYPE
    {
        HEALTH,
        POISON,
        LASER,
        SPEED,
        SLOW
    }
    public PICKUPTYPE myType = PICKUPTYPE.HEALTH;
    [HideInInspector]
    public bool Used = false;
    #endregion
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Used)
        {
            Destroy(this.gameObject);
        }
    }
    #endregion
}
