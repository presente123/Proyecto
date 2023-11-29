using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Enemigo : MonoBehaviour
{
    public GameObject jugador;
    public GameObject enemigo;

    public int L�miteVida = 3;
    public int Vida;
    public int da�o = 1;
    public int puntaje = 1;

    private void Start()
    {
        Vida = L�miteVida;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Movimiento_Pers>().RecibirDa�o(da�o);
            Destroy(enemigo);
            jugador.GetComponent<Movimiento_Pers>().SumarPuntos(puntaje);
        }
    }

    public void RecibirDa�o(int da�o)
    {
        Vida -= da�o;

        if (Vida <= 0)
        {
            Destroy(enemigo);
            jugador.GetComponent<Movimiento_Pers>().SumarPuntos(puntaje);
        }
    }

}
