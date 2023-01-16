using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potioncollisiontext : MonoBehaviour
{
    [SerializeField] private Text keytext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("potiongreen"))
        {
            keytext.text = "Potion: Double Jump" ;

        }
        else if (collision.gameObject.CompareTag("potion"))
        {
            keytext.text = "Potion: Teleport";
        }
    }

}
