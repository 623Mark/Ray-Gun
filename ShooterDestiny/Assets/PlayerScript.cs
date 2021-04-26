using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    Object bulletRef;


    // Start is called before the first frame update
    void Start()
    {
        bulletRef = Resources.Load("Bullet");
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey("space") && isGrounded)
        //if(Input.GetButtonSpace("Fire1"))
        //if(Input.GetKeyDown("Fire1")) || Input.GetKeyDown("space"))
        if(Input.GetButtonDown("Fire1"))
        {
            animator.Play("Player_shoot3");
            GameObject bullet = (GameObject)Instantiate(bulletRef);
            //GameObject projectile= Instantiate (prefab, position, rotation) as GameObject;
            bullet.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, 0);
        }
    }
}
