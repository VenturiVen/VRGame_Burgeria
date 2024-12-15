using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BtnTray : MonoBehaviour
{
    [SerializeField] GameObject servedFood;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ButtonPress());
    }

    public void ButtonPress()
    {
        servedFood.GetComponent<ServeFood>().Serve();
    }
}
