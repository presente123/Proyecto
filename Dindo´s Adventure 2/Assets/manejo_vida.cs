using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manejo_vida : MonoBehaviour
{
    public Image vida;
    public GameObject jugador;
    private float promedio_vida;
    private float Vida_m�xima;
    private float Vida_actual;

    // Start is called before the first frame update
    void Start()
    {
        Vida_m�xima = jugador.GetComponent<Movimiento_Pers>().L�miteVida;
        Vida_actual = Vida_m�xima;

    }

    // Update is called once per frame
    void Update()
    {

        Vida_m�xima = jugador.GetComponent<Movimiento_Pers>().L�miteVida;
        Vida_actual = jugador.GetComponent<Movimiento_Pers>().Vida;

        promedio_vida = Vida_actual / Vida_m�xima;

        vida.fillAmount = promedio_vida;

    }
}
