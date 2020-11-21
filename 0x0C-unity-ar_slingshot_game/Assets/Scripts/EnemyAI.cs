using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.ARFoundation;

public class EnemyAI : MonoBehaviour
{
    Vector3 randomTarget;
    Vector3 normalized;
    bool offEdge;
    Bounds bounds;

    void Awake()
    {
        bounds = SelectPlane.chosenPlane.GetComponent<MeshCollider>().bounds;
        randomTarget = new Vector3(SelectPlane.chosenPlane.center.x + Random.Range(bounds.min.x, bounds.max.x), transform.position.y, SelectPlane.chosenPlane.center.z + Random.Range(bounds.min.z, bounds.max.z));
        normalized = (randomTarget - transform.position).normalized;
        transform.LookAt(normalized);
    }
    void Update()
    {
        if (!CheckEdge())
            return;
        transform.position += normalized * (Time.deltaTime / 2);
    }

    private bool CheckEdge()
    {
        RaycastHit objectHit;
        Vector3 pos = transform.position;
        pos.y += 0.07f;
        if (Physics.Raycast(pos, transform.forward + (-transform.up), out objectHit, 50))
        {
            if (offEdge)
            {
                normalized = (randomTarget - transform.position).normalized;
                offEdge = false;
            }
            return true;
        }
        else
        {
            offEdge = true;
            randomTarget = new Vector3(SelectPlane.chosenPlane.center.x + Random.Range(bounds.min.x, bounds.max.x), transform.position.y, SelectPlane.chosenPlane.center.z + Random.Range(bounds.min.z, bounds.max.z));
            transform.LookAt(randomTarget);
            return false;
        }
    }
}
