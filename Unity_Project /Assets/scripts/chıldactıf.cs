using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;



public class chıldactıf : MonoBehaviour
{
    public Renderer ren;
    
    private void Start()
    {
        //object is invisible in the start
        ren = GetComponent<Renderer>();
        ren.enabled = false;
    }
    void  Update()
    {
        // Check if the button is pressed
       // bool check = Input.GetKey(KeyCode.B);

        // Enable renderer accordingly
        //this makes it visible
       // ren.enabled = check;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("box"))
        {
            ren.enabled = true;

       }
    }//for some reason this doesn't work, so I used the code above to test the renderer worked and it works. we just need to add a more correct if statement i think
}
