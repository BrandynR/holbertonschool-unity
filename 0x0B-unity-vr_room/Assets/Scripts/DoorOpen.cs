using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;

    public void Interact()
    {
        if (InRange())
        {
            DoorTrigger();
        }
    }

    bool InRange()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 2f)
        {
            return (true);
        }
        return (false);
    }

    public void DoorTrigger()
    {
        doorAnimator.SetBool("character_nearby", true);
        Debug.Log("Opening Door");
    }
}
