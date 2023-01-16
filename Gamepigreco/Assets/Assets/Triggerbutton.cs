using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbutton : MonoBehaviour
{ 

    public GameObject DIO;

    private void Start()
    {
        DIO.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sprite1") && this.name == "Square(1)")
        {
            DIO.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sprite1") && this.name == "Square(1)")
        {
            DIO.SetActive(false);
        }
    }
}


