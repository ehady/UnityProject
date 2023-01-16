using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class notecollision : MonoBehaviour
{
  private int note = 0;
  [SerializeField] private Text keytext;
  public AudioClip NoteSound;

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if(collision.gameObject.CompareTag("Note"))
      {
          note++;
          keytext.text = "Note : " + note;
           Destroy(collision.gameObject);
      }
      
  }
}
