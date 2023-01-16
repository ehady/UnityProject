using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{

    public GameObject objectToThrow;
    public float throwForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            GameObject thrownObject = Instantiate(objectToThrow, transform.position, Quaternion.identity);
            Rigidbody2D rb = thrownObject.GetComponent<Rigidbody2D>();
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 throwDirection = (mousePos - (Vector2)transform.position).normalized;
            rb.AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
        }
    }
}
