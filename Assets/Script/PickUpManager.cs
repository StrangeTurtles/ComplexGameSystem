using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Com.MyCompany.MyGame;

/// <summary>
/// Place on the player to keep track of the power ups
/// </summary>
public class PickUpManager : MonoBehaviour
{
    private PickUp pickUp;
    private PlayerManager target;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (!animator)
        {
            //Debug.LogError("PlayerAnimatorManager is Missing Animator Component", this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PickUp>() != null)
        {
            switch (other.GetComponent<PickUp>().myType)
            {
                case PickUp.PICKUPTYPE.HEALTH:
                    target.Health += 0.1f;
                    break;
                case PickUp.PICKUPTYPE.POISON:
                    target.Health -= 0.1f;
                    break;
                case PickUp.PICKUPTYPE.LASER:
                    target.FiringActived = true;
                    break;
                case PickUp.PICKUPTYPE.SPEED:
                    animator.SetFloat("Speed", animator.GetFloat("Speed") * 2);
                    break;
                case PickUp.PICKUPTYPE.SLOW:
                    animator.SetFloat("Speed", animator.GetFloat("Speed") / 2);
                    break;
                default:
                    break;
            }
            other.GetComponent<PickUp>().Used = true;
        }
    }
}
