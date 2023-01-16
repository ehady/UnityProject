using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    bool movable;
    public bool isDown; 
    public bool isUp;
    public bool moveDown;
    public bool moveUp;

    Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        isUp = true;
        /*isDown = false;*/
        moveDown = false;
        moveUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDown)
        {
            m_animator.SetTrigger("Down");
            isUp = false;
            //isDown = true;
        }
        if (moveUp)
        {
            m_animator.SetTrigger("Up");
            m_animator.SetTrigger("Default");
            isUp = true;
            //isDown = false;
        }
        moveDown = false;
        moveUp = false;

    }

    public void MoveDown(Boolean set)
    {
        moveDown = set;
    }
    public void MoveUp(Boolean set)
    {
        moveUp = set;
    }



}
