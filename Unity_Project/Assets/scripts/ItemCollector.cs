using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text keytext;
    [SerializeField] 
    private int key = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            key++;
            keytext.text = "Keys : " + key;

        }
    }
    
}
