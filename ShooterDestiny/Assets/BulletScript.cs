using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //---
    public float bulletSpeed = 3f;
    public float bulletDamage = 1f;
    //--    

    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    //void Start(bool isFacingLeft)
    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
        //if(isFacingLeft)
        rb2d = GetComponent<Rigidbody2D>();
        
        Invoke("DestroySelf", .3f);

        //rb2d.velocity = new Vector2(3, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            //rb2d.AddForce(new Vector2(20, 0));
        //rb2d.velocity = new Vector2(3, 0);
        rb2d.velocity = Vector2.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            DestroySelf();
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
