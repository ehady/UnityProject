using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndThrow : MonoBehaviour
{
    public float throwForce = 10f;
    private GameObject pickedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Raycast to check if player is pointing at a pickable object 
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null && hit.collider.CompareTag("Pickable"))
            {
                // Pick up the object
                pickedObject = hit.collider.gameObject;
                pickedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                pickedObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                pickedObject.transform.SetParent(transform);
            }
        }
        if(Input.GetMouseButtonUp(0) && pickedObject != null)
        {
            //Throw the object
            pickedObject.GetComponent<Rigidbody2D>().isKinematic= false;
            Vector2 throwDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
            pickedObject.GetComponent<Rigidbody2D>().AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
            pickedObject.transform.SetParent(null);
            pickedObject = null;



        }
    }
}
