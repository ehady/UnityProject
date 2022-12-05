using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    Animator myAnimator;
    private bool hasPlayer;
    const string Moving = "LeverMove";
    // Start is called before the first frame update
    void Start()
    {
        myAnimator= GetComponent<Animator>();
    }
    
    private void Update()
    {
        //All the levers in the level is moving with this script
        //I tried using EnterCollision and ExitCollision but it didn'T work
        if(Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger(Moving);

        }
    }



    // Update is called once per frame


}
