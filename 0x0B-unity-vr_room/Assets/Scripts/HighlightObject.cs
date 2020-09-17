using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    public GameObject interactable;
   // public Transform grab;
 void OnMouseEnter()
 {
     interactable.GetComponent<Outline>().enabled = true;
 }
 void OnMouseExit()
 {
     interactable.GetComponent<Outline>().enabled = false;
 }
/*void OnMouseBottonDown()
{
    interactable.transform.position = grab.transform.position;
}*/

}