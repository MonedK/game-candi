using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekKunci : MonoBehaviour
{

    [SerializeField]
    private Transform objekPlace;
    private Vector3 initialPosition;
    private float deltaX, deltaY, deltaZ;
    public static bool locked;
    private static ObjekKunci instance;
    AudioSource tick;
    AudioSource error;
    public AudioClip impact;
    public AudioClip wrong;

    // Start is called before the first frame update
    void Awake()
    {
        
        initialPosition = transform.position;
        tick = GetComponent<AudioSource>();
        error = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if(Mathf.Abs(transform.position.x - objekPlace.position.x)<= 0.5f&&
                Mathf.Abs(transform.position.y - objekPlace.position.y) <= 0.5f &&
                Mathf.Abs(transform.position.z - objekPlace.position.z) <= 0.5f)
            {
                transform.position = new Vector3(objekPlace.position.x, objekPlace.position.y, objekPlace.position.z);
                locked = true;
                //AudioSource audio = gameObject.AddComponent<AudioSource>();
                tick.PlayOneShot(impact, 1f);
            }
            else
            {
                transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
                //AudioSource audio1 = gameObject.AddComponent<AudioSource>();
                error.PlayOneShot(wrong, 1f);
            }
            
            
        }
    }
}
