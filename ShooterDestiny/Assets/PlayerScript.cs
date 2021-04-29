using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    Object bulletRef;

    bool isFacingLeft;

    // public Animation anim;
    // SpriteRenderer spriteRenderer;

            //bool isGrounded;

    //public float desiredSpeed;


    // Start is called before the first frame update
    void Start()
    {
        bulletRef = Resources.Load("Bullet");
        animator = GetComponent<Animator>();

        
        // anim = GetComponent<Animation>();
        // anim["Player_shoot3"].normalizedSpeed = anim["Player_run"].normalizedSpeed;
        // spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void ResetShoot()
    {
        animator.Play("Player_idle");
    }


    //void FixedUpdate()
    void Update()

    //private void FixedUpdate()
    {
        //if(Input.GetKey("space") && isGrounded)
        //if(Input.GetButtonSpace("Fire1"))
        //if(Input.GetKeyDown("Fire1")) || Input.GetKeyDown("space"))

        if(Input.GetButtonDown("Fire1"))
        //if (Input.GetKey("z"))
        {            
            // if (AnimationState.time >= AnimationState.length)
            // {
            //     // animation finished...
            //     animator.Play("Player_shoot3");
            // }
                //if(isGrounded)
                        //animator.speed = 1f;
             //Time.timeScale = 0.5f;
             //if(isGrounded)
            animator.Play("Player_shoot3");

            // desiredSpeed = 0.01f;
            // animator.speed = desiredSpeed;

            GameObject bullet = (GameObject)Instantiate(bulletRef);
            //GameObject projectile= Instantiate (prefab, position, rotation) as GameObject;
            bullet.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, 0);
        }

            //         else if (Input.GetKey("a") || Input.GetKey("left"))
            // {
            //     rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            //     // Set the frame of running state(left).
            //     if(isGrounded)
            //         animator.Play("Player_run");

            //     spriteRenderer.flipX = true;

            // }
        // IEnumerator Start()
        // {
        //     yield return GetComponent<Animation>().WhilePlaying("Player_shoot3");
        // }

    }
}
