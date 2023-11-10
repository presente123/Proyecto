using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador_Puntos : MonoBehaviour
{
    public Text textocontador;
    public GameObject jugador;
    private int puntuacion = 0;

    void Update()
    {
        puntuacion = jugador.GetComponent<Movimiento_Pers>().NivelTotal;

        textocontador.text = puntuacion.ToString();
    }
}
