using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 3.0f;
    public float jumpSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = rb.velocity;

        if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("RIGHT");
            movement.x = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LEFT");
            movement.x = -moveSpeed;

        }
        else
        {
            movement.x = 0;
        }

        if (Input.GetKey(KeyCode.Space) && rb.velocity.y ==0) {
            movement.y = 15;
            GetComponent<Animator>().SetBool("IsJumping", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("IsJumping", false);
        }
        rb.velocity = movement;


        GetComponent<Animator>().SetFloat("JumpState", rb.velocity.y);

    }
   

}
