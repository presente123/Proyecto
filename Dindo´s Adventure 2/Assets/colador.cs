using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colador : MonoBehaviour
{

    public GameObject personaje;

    public GameObject Enemigo;

    public int vida;

    private void Start()
    {
        vida = 10;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Proyectil_Jugador"))
        {
            // Lógica de colisión entre personajes
            Destroy(Enemigo);
            //Debug.Log("x_eje, y_eje");

            //Movimiento_bala daño = collision.gameObject.GetComponent<daño>();
            //vida = daño;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        {
            // Lógica de colisión entre personajes
        //    Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
