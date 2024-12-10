using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public List<string> targetTags = new List<string>();
    public UnityEvent<GameObject> enterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (targetTags.Contains(other.gameObject.tag))
        {
            enterEvent.Invoke(other.gameObject);
        }
    }
}
