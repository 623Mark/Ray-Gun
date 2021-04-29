using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int health = 10;

    //materials
    private Material matWhite;
    private Material matDefault;
    private UnityEngine.Object explosionRef;
    SpriteRenderer sr;

    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = sr.material;
        //--Explosion 
        explosionRef = Resources.Load("Explosion");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // collision.tag == "Bullet"
        if(collision.CompareTag("Bullet")) 
        {
            Destroy(collision.gameObject);
            health--;
            sr.material = matWhite;

            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);

            if(health <= 0)
            {
                KillSelf();
            }
            else
            {
                Invoke("ResetMaterial", .1f);
            }
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    private void KillSelf()
    {
        // TODO Add particle Burst
        GameObject explosion = (GameObject)Instantiate(explosionRef);
        explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
        //explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, 0);
        Destroy(gameObject);
        

    }
}
