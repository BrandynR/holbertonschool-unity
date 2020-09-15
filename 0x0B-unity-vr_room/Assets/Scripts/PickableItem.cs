using UnityEngine;
/// <summary>
/// Attach this class to make object pickable.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PickableItem : MonoBehaviour
{
    // Reference to the rigidbody
    private Rigidbody rb;
    public Rigidbody Rb => rb;
    /// <summary>
    /// Method called on initialization.
    /// </summary>
    private void Awake()
    {
        // Get reference to the rigidbody
        rb = GetComponent<Rigidbody>();
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public Transform player;
    public Transform pocket;
    private Camera main;
    //float distance = Vector3.Distance(objectA.transform.position, objectB.transform.position);
    //float yourdistance = 
    public void Interact()
    {
        if (InRange()) //(distance <= yourdistance)
        {
            Debug.Log("In Range");
            if (pocket.childCount == 0)
                ObjectPickup();
            else
                ObjectSwap();
        }
        else
        {
            Debug.Log("Not In Range");
        }
    }

    bool InRange()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= 3f)
        {
            return (true);
        }
        return (false);
    }

    void ObjectPickup()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        transform.position = pocket.position;
        transform.parent = GameObject.Find("Grab Slot").transform;
    }

    void ObjectSwap()
    {
        Transform dropping = pocket.GetChild(0);
        dropping.position = transform.position;
        dropping.parent = null;
        ObjectPickup();
        dropping.GetComponent<Rigidbody>().isKinematic = false;
    }
}*/
