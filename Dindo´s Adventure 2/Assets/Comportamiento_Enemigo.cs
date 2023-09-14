using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Enemigo : MonoBehaviour
{
    public GameObject enemigo;

    public int L�miteVida = 3;
    public int Vida;

    private void Start()
    {
        Vida = L�miteVida;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Proyectil_Jugador"))
        {
            //collision.gameObject.GetComponent<Movimiento_bala>();
            //Destroy(enemigo);
        }
    }

    public void RecibirDa�o(int da�o)
    {
        Vida -= da�o;

        if (Vida <= 0)
        {
            Destroy(enemigo);
        }
    }

}
