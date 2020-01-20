using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetchangepos : MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;
    public bool testing;

    // Movement speed in units per second.
    public float speed = 10F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    public void Start()
    {

        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Magnet");
        {
            testing = true;
        }
         
    }
    // Move to the target end position.
    void Update()
    {
        if(testing == true)
        {
            
            // Distance moved equals elapsed time times speed..
            float distCovered = (Time.deltaTime) * speed;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
        }

    }
}
