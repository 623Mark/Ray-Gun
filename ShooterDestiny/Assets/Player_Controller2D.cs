using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller2D : MonoBehaviour
{

    // Three different properties
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    // Map the keyboard buttons.
    private void FixedUpdate()
    {
        // Left, Right movement.
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2, rb2d.velocity.y);
            // Set the frame of running state(right).
            animator.Play("Player_run");
        } 
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);
            // Set the frame of running state(left).
            animator.Play("Player_run");
        }
        // After user/player stop doing above, revert animation to the idle.
        else
        {
            animator.Play("Player_idle");
        }

        // Jump state
        if(Input.GetKey("space"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 3);
            animator.Play("Player_jump");
        }
    }


}
