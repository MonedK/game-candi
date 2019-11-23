using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoxCollider))]

public class MouseDrag : MonoBehaviour
{
  public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        rb.MovePosition(pos_move.x + pos_move.y + transform.position.z);
    }
    /*void FixedUpdate()
    {
        // Moves the GameObject to the left of the origin.
        if (transform.position.x > 3.0f)
        {
            transform.position = new Vector3(-3.0f, 0.0f, 0.0f);
        }

        rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
    }
    */

    /*void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);

    }
    */
}
