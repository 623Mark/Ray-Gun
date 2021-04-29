using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
{
    Animator animator;
    SpriteRenderer spriteRenderer;

    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 5;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;

    public bool _moveRight = true;


    // Use this for initialization
    public void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

         enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = -transform.localScale.x > 0;
    }


// Update is called once per frame
public void Update()
{

    if (_moveRight)
    {
        //rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
        //enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
        //bullet.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, 0);
        enemyRigidBody2D.velocity = new Vector2(EnemySpeed, enemyRigidBody2D.velocity.y);
        if (!_isFacingRight)
            
            Flip();
            animator.Play("Alien_run");
            
    }

    if (enemyRigidBody2D.position.x >= _endPos)
        _moveRight = false;
        //_moveRight = true;

    if (!_moveRight)
    {
        //enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
        enemyRigidBody2D.velocity = new Vector2(-EnemySpeed, enemyRigidBody2D.velocity.y);
        if (_isFacingRight)
            
            Flip();
            animator.Play("Alien_run");
            //Flip();
            
            
    }
    if (enemyRigidBody2D.position.x <= _startPos)
        _moveRight = true;
        //_moveRight = false;


}

    public void Flip()
    {
        //enemyRigidBody2D.position.flipX = true;
        spriteRenderer.flipX = true;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = -transform.localScale.x > 0;
    }

}
