using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notecollision : MonoBehaviour
{
  private int note = 0;
  private void OnTriggerEnter2D(Collider2D collision)
  {
      if(collision.gameObject.CompareTag("Note"))
      {
          note++;
      }
  }
}
