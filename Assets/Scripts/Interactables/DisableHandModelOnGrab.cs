using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandModelOnGrab : MonoBehaviour
{
    // scrip disables hand model when it is holding an object
    // so the object is more visible
    // and the hand isn't holding the object awkwardly

    private GameObject leftHandModel;
    private GameObject rightHandModel;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideHandModel);
        grabInteractable.selectExited.AddListener(ShowHandModel);
        leftHandModel = FetchHandmodels.Instance.GetLeftHandModel(); 
        rightHandModel = FetchHandmodels.Instance.GetRightHandModel(); 
    }

    public void HideHandModel(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowHandModel(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }
}
