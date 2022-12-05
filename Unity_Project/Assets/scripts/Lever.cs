using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    Animator myAnimator;
    private bool keydown;   
    const string Moving = "LeverMove";
    private bool hasPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator= GetComponent<Animator>();
        
    }
    
    private void Update()
    {
        //All the levers in the level is moving with this script
        //I tried using EnterCollision and ExitCollision but it didn'T work
        
        
            if(hasPlayer && Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger(Moving);

        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayer= true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayer= false;
        }


    }




    // Update is called once per frame


}