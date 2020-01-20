using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekKunci2 : MonoBehaviour
{
    [SerializeField]
    private Transform objekPlace;
    private Vector3 initialPosition;
    private float deltaX, deltaY, deltaZ;
    public static bool locked;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Mathf.Abs(transform.position.x - objekPlace.position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - objekPlace.position.y) <= 0.5f &&
                Mathf.Abs(transform.position.z - objekPlace.position.z) <= 0.5f)
            {
                transform.position = new Vector3(objekPlace.position.x, objekPlace.position.y, objekPlace.position.z);
                locked = true;
            }
            else
            {
                transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
            }


        }
    }
}
