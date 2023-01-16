using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    Animator myAnimator;
    GameObject platform;    
    private bool hasPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator= GetComponent<Animator>();
        platform = GameObject.Find("Platform");
        
    }
    
    private void Update()
    {
        //All the levers in the level is moving with this script
        //I tried using EnterCollision and ExitCollision but it didn'T work


        if (hasPlayer && Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger("Move");
            if (platform.GetComponent<Lift>().isUp)
            {
                platform.GetComponent<Lift>().MoveDown(true);

            }
            else
            {
                platform.GetComponent<Lift>().MoveUp(true);
            }

            /*if (platform.GetComponent<Lift>().isDown)
            {
                platform.GetComponent<Lift>().MoveUp(true);
            }
            else
            {
                platform.GetComponent<Lift>().MoveUp(false);
            }*/


        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasPlayer = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
            hasPlayer= false;     


    }
    // Update is called once per frame


}
