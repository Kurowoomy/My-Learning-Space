using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;
    public float speed = 5;
    //float verticalIncline = 0.4f;

    void Start()
    {
        //instead of dragging the component to script inside unity:
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() //input
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate() //movement
    {
        //make vertical movement incline
        //if (Mathf.Abs(movement.y) > 0) movement.x = (movement.y > 0 ? movement.x + verticalIncline : movement.x - verticalIncline);

        //move player
        if (Mathf.Abs(movement.x) > 0 && Mathf.Abs(movement.y) > 0)
            rb.MovePosition((Vector2)transform.position + movement.normalized * speed * Time.fixedDeltaTime);
        else
            rb.MovePosition((Vector2)transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
