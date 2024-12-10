using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayOnTilt : MonoBehaviour
{ 
    // script to be attached to particle system as component
    // if particle system is tilted more than 90 degrees,
    // particle plays
    
    // (meant to mimic pouring)

    public ParticleSystem particles;
    [SerializeField] private float tilt = 90f;

    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= tilt)
        {
            particles.Play();
        }
        else
        {
            particles.Stop();   
        }
    }
}
