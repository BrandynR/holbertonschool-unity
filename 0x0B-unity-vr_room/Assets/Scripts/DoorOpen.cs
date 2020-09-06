using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator doorAnimator;
    public Transform player;
    public GameObject mini;

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
        if (dist <= 1f)
        {
            return (true);
        }
        return (false);
    }

    public void DoorTrigger()
    {
        doorAnimator.SetTrigger("character_nearby");
    }
}
