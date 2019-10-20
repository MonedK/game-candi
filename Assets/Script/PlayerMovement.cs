using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rb;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 9f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);

        if (rb.position.y < -6f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }

        if(rb.position.y > 25f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }

}
