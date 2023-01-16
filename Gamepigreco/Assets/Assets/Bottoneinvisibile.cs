using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottoneinvisibile : MonoBehaviour

{
    public GameObject DIO;
    void Start()
    {
        DIO.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sprite1"))
        {
            DIO.SetActive(true);
        }
    }
}