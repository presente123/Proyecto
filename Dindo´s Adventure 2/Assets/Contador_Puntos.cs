using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador_Puntos : MonoBehaviour
{
    public Text textocontador;
    private int puntuacion = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            puntuacion += 1;
        }

        textocontador.text = puntuacion.ToString();
    }
}
