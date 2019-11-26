using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableObject : MonoBehaviour
{
    GameObject grabbedObject;
    float grabbedObjectSize;


    GameObject GetMouseHoveObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward * range;
        if (Physics.Linecast(position, target, out raycastHit))
            return raycastHit.collider.gameObject;
        return null;
    }

    bool canGrab(GameObject candidate)
    {
        return candidate.GetComponent<Rigidbody>() != null;
    }

    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null || !canGrab(grabObject))
            return;
        grabbedObject = grabObject;
        grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude; 
    }

    void DropObject()
    {
        if (grabbedObject == null)
            return;

        if (grabbedObject.GetComponent<Rigidbody>() != null)
            grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        grabbedObject = null;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (grabbedObject == null)

                TryGrabObject(GetMouseHoveObject(5));
            else
                DropObject();
        }                   
        if(grabbedObject != null)
            {
                Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
                grabbedObject.transform.position = newPosition;
            }
                
    }
}
