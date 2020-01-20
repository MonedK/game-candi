using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecamera : MonoBehaviour
{
    public Camera gameCamera;
    public Camera inspectCamera;

    public void ShowInspectCamera()
    {
        gameCamera.enabled = false;
        inspectCamera.enabled = true;
    }

    public void ShowGameCamera()
    {
        gameCamera.enabled = true;
        inspectCamera.enabled = false;
    }
}
