using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireColission : MonoBehaviour
{
private Rigidbody2D rb;
private Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

 private void OnCollisionEnter2D(Collision2D collision) 
 { if (collision.gameObject.CompareTag("fire"))
 {

     Die();

 }
 }
private void Die()
{
    rb.bodyType = RigidbodyType2D.Static;
 anim.SetTrigger("die");
}


 
}
