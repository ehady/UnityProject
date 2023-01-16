using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject objectToPickup;
    public Transform holdPosition;
    public ThrowHeldObject throwHeldObject;
    public float threshold = 100.5f;
    private bool holdingObject = false;

    void Update()
    {
        //if (Vector3.Distance(transform.position, objectToPickup.transform.position) < threshold)
        
            if (Input.GetKeyDown(KeyCode.E) && !holdingObject)
            {
                Pickup();
            }
            else if (Input.GetKeyDown(KeyCode.E) && holdingObject)
            {
                Release();
            }
        

    }

    void Pickup()
    {
        objectToPickup.transform.position = holdPosition.position;
        objectToPickup.transform.parent = gameObject.transform;
        objectToPickup.GetComponent<Rigidbody2D>().isKinematic = true;
        holdingObject = true;
        throwHeldObject.setHeldObject(objectToPickup);


    }

    void Release()
    {
        objectToPickup.transform.parent = null;
        objectToPickup.GetComponent<Rigidbody2D>().isKinematic = false;
        holdingObject = false;
    }
}