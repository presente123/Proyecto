using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamiento_Enemigo : MonoBehaviour
{
    public GameObject enemigo;

    public int LímiteVida = 3;
    public int Vida;
    public int daño = 1;

    private void Start()
    {
        Vida = LímiteVida;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Movimiento_Pers>().RecibirDaño(daño);
            Destroy(enemigo);
        }
    }

    public void RecibirDaño(int daño)
    {
        Vida -= daño;

        if (Vida <= 0)
        {
            Destroy(enemigo);
        }
    }

}
