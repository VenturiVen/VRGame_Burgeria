using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchHandmodels : MonoBehaviour
{
    // reused my code from my other project for this
    // other project: https://github.com/VenturiVen/3D_FPS

    // this file is so instantiated interactable objects can access the hand models

    public static FetchHandmodels Instance;

    public GameObject leftHandModel;
    public GameObject rightHandModel;

    private void Awake()
    {
        // check if there already is an Instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(global::FetchHandmodels.Instance);
        }
    }

    public GameObject GetLeftHandModel()
    {
        return leftHandModel;
    }

    public GameObject GetRightHandModel()
    {
        return rightHandModel;
    }
}
