using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LineRendererManager : MonoBehaviour
{
    [SerializeField]
    GameObject Interactor;

    [SerializeField]
    GameObject LineVisual;

    [SerializeField]
    public LayerMask hitRayMask;

    float maxDistance = 30.0f;

    void Update()
    {
        if (Physics.Raycast(Interactor.transform.position, Interactor.transform.forward, out RaycastHit hitInfo, maxDistance, hitRayMask))
        {
            if (hitInfo.transform.GetComponent<Canvas>() == true)
            {
                LineVisual.transform.GetComponent<XRInteractorLineVisual>().enabled = true;
            }
        }
        else
        {
         LineVisual.transform.GetComponent<XRInteractorLineVisual>().enabled = false;
        }
    }
}
