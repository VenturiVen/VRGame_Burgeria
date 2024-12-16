using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BtnSpawnChute : MonoBehaviour
{
    [SerializeField] GameObject spawnItem;
    GameObject itemInstance;
    [SerializeField] Transform spawnLocation;

    /*
    // to track number of food items
    [SerializeField] private int spawnLimit;
    List<GameObject> food = new List<GameObject>();
    */

    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ButtonPress());
    }

    private void ButtonPress()
    {
        SpawnItem();
    }

    private void SpawnItem()
    {
        itemInstance = (GameObject)Instantiate(spawnItem, spawnLocation.position, spawnLocation.rotation);
    }
}
