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
            // L�gica de colisi�n entre personajes
            Destroy(Enemigo);
            //Debug.Log("x_eje, y_eje");

            //Movimiento_bala da�o = collision.gameObject.GetComponent<da�o>();
            //vida = da�o;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        {
            // L�gica de colisi�n entre personajes
        //    Debug.Log("haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
}
