using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colador : MonoBehaviour
{

    public GameObject personaje;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // L�gica de colisi�n entre personajes
            Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // L�gica de colisi�n entre personajes
            Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
