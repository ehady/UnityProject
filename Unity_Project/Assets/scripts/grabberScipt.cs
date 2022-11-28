using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class grabberScipt : MonoBehaviour
{
    public bool grabbed;
    RaycastHit2D hit;
    public float distance=2f;
    public UnityEngine.Transform holdPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if (!grabbed) //grab
            {
                Physics2D.queriesStartInColliders = false;
                hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x,distance);
                
                if(hit.collider!= null)
                {
                    grabbed= true;

                }


            }
            else { 
            } //throw
        }
        if(grabbed)
        {
            hit.collider.gameObject.transform.position = holdPoint.position;
        }
    }
}

/*void OnDrawGizmos()
{
    Gizsmos.color = Color.green;
    Gizmos.DrawLine(Transform.positiion,Transform.position+ Vector2.right * transform.localScale.x, distance);
}*/
