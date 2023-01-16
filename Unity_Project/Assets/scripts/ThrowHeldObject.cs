using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHeldObject : MonoBehaviour
{
    private GameObject heldObject;
    public float throwForce = 1000f;
    private bool holdingObject = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && holdingObject)
        {
            Throw();
        }
    }

    void Throw()
    {
        holdingObject = false;
        heldObject.transform.parent = null;
        heldObject.GetComponent<Rigidbody2D>().isKinematic = false;
        //Vector3 throwDirection = transform.rotation * Vector3.forward;
        //heldObject.GetComponent<Rigidbody2D>().AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
        heldObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * throwForce, ForceMode2D.Impulse);
    }

    public void setHeldObject(GameObject obj)
    {
        heldObject = obj;
        holdingObject = true;
    }
}
