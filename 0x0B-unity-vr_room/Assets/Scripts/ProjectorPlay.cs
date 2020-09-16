using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorPlay : MonoBehaviour
{
    //public ParticleSystem particles;
    public GameObject particleSystem;
    //bool hologram;

    public void ProjectorOn()
    {
        if (particleSystem.active)
        {
            particleSystem.SetActive(false);
        }
        else
        {
            particleSystem.SetActive(true);
        }
        //particles.Play();
    }

}
