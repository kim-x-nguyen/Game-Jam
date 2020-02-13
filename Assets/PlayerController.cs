using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed; //How fast the character moves around the environment
    public float jumbForce; //How high the character will jumb
    public float moveInput; //Check the left - right input from the keyboard

    private Rigidbody2D rb;

    void Start()//Get component of rigidbody
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()//Manage physics
    {
        moveInput = Input.GetAxis("Horizontal");//Use Left and Right Arrow keys
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}

