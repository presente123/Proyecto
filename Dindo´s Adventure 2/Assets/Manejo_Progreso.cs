using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manejo_Progreso : MonoBehaviour
{
    public Image Progreso;
    public GameObject jugador;
    private float promedio_progreso;
    private float progreso_máximo;
    private float progreso_nivel1;
    private float progreso_nivel2;
    private float progreso_nivel3;
    private float progreso_nivelfinal;
    private float progreso_actual;
    // Start is called before the first frame update
    
    void Start()
    {
        progreso_actual = 0;
        progreso_nivel1 = jugador.GetComponent<Generador_Oleadas>().nivel1;
        progreso_nivel2 = jugador.GetComponent<Generador_Oleadas>().nivel2;
        progreso_nivel3 = jugador.GetComponent<Generador_Oleadas>().nivel3;
        progreso_nivelfinal = jugador.GetComponent<Generador_Oleadas>().nivelfinal;

        progreso_máximo = progreso_nivel1;
    }

    // Update is called once per frame
    void Update()
    {
        progreso_actual = jugador.GetComponent<Movimiento_Pers>().NivelTotal;
        Nivelar();

        promedio_progreso = progreso_actual / progreso_máximo;

        Progreso.fillAmount = promedio_progreso;
    }

    private void Nivelar()
    {
        if (progreso_actual >= progreso_nivel1)
        {
            progreso_actual -= progreso_nivel1;
            progreso_máximo = progreso_nivel2;
        } 
        
        if (progreso_actual >= progreso_nivel2)
        {
            progreso_actual -= progreso_nivel2;
            progreso_máximo = progreso_nivel3;
        }
        
        if (progreso_actual >= progreso_nivel3)
        {
            progreso_actual -= progreso_nivel3;
            progreso_máximo = progreso_nivelfinal;
        }

    }
}
