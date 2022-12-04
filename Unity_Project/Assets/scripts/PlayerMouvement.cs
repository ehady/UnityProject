using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    [SerializeField] private LayerMask jumpableGround;
    private BoxCollider2D coll;
    private Rigidbody2D rb;

    private Animator anim;
    private float dirX = 0f;
    
    private SpriteRenderer sprite;
    [SerializeField] private float movespeed = 7f;
    [SerializeField] private float jumpforce = 14f;
    private bool doublejump;
    private bool greenpotioncolision;
    private bool redpotioncolision;

    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("potiongreen"))
        {
            Destroy(collision.gameObject);
            greenpotioncolision = true;

        }
        if (collision.gameObject.CompareTag("potion"))
        {
            Destroy(collision.gameObject);
            redpotioncolision = true;

        }
    }
    


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && redpotioncolision)
        {

            transform.position = new Vector2(transform.position.x + 5f, transform.position.y);


        }
        if (Input.GetKeyDown(KeyCode.Q) && redpotioncolision)
        {

            transform.position = new Vector2(transform.position.x - 5f, transform.position.y);


        }
        if ( GroundCheck() && !Input.GetButton("Jump"))
        {
            doublejump = false;
        }
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * movespeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") )

        {
            if (GroundCheck() || doublejump && greenpotioncolision )
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
                doublejump = !doublejump;
            }
        }
        uppdateAnimationupdate();
        
    }
    
  
    private void uppdateAnimationupdate()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
    private bool GroundCheck()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);



    }
}
