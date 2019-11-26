using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseDrag : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;

    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector2 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    //void FixedUpdate()
    //{
    //  moveCharacter(movement);
    //}
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
    
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
            }
            moveCharacter(movement);

            void moveCharacter(Vector2 direction)
            {
                rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
            }
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        }
    
        
    }
    
    
}
