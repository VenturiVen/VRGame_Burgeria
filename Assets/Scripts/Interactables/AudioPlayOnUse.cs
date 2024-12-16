using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AudioPlayOnUse : MonoBehaviour
{

    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;

    private bool played = false;

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartParticles());
        grabInteractable.deactivated.AddListener(x => StopParticles());
    }

    public void StartParticles()
    {
        if (!played)
        {
            played = true;
            source.PlayOneShot(clip);
        }
    }

    public void StopParticles()
    {
        if (played)
        {
            played = false;
        }
    }
}
