using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller2D : MonoBehaviour
{

    // Three different properties
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;


                // private bool grounded = false;
                // [SerializeField]
                // private Transform groundCheck;
                // private Transform myTransform;

                // void Awake () 
                // {

                // // Set up references
                // groundCheck = transform.Find("groundCheck");
                // myTransform = transform;

                // }
    bool isGrounded;

    [SerializeField]
    Transform groundCheck;

        // var mask : LayerMask = -1;
        // var onGround = false;
    
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
        //grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            // groundCheck = Physics2D.Raycast(transform.position, -transform.up, 1, mask.value);
            //  if(groundCheck.collider != null)
            // {
            // onGround = true;
            // }
            // else
            // {
            // onGround = false;
            // }

        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else 
        {
            isGrounded = false;
        }

        // Left, Right movement.
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2, rb2d.velocity.y);
            // Set the frame of running state(right).
            animator.Play("Player_run");
            spriteRenderer.flipX = false;

        } 
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);
            // Set the frame of running state(left).
            animator.Play("Player_run");
            spriteRenderer.flipX = true;

        }

        // After user/player stop doing above, revert animation to the stand idle.
        else
        {
            animator.Play("Player_idle");
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);

        }

        // Jump state
            //if(Input.GetKey("space") && isGrounded)
        if(Input.GetKey("space") && isGrounded)
        {
                //onGround = true;

            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            //animator.Play("Player_jump");
            animator.Play("Player_jump1Frame");

        }
    }


}
