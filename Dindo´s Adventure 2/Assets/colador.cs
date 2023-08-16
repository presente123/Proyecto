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
            // Lógica de colisión entre personajes
            Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Lógica de colisión entre personajes
            Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
