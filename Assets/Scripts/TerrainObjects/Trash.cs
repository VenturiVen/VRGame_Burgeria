using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().enterEvent.AddListener(TrashObject);
    }


    private void TrashObject(GameObject go)
    {
        // disabling an object doesn't delete the object from memory
        // but object stops using up CPU
        go.SetActive(false); 
    }
}
