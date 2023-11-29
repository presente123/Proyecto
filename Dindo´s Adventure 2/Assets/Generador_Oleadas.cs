using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Oleadas : MonoBehaviour
{
    public GameObject jugador;
    public GameObject menu;
    public GameObject[] listado;
    public GameObject barra;
    public int contador;
    public int fase;
    public int nivel1 = 3;
    public int nivel2 = 6;
    public int nivel3 = 9;
    public int nivelfinal = 16;
    private int progreso; 

    // Start is called before the first frame update
    void Start()
    {
        fase = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        progreso = jugador.GetComponent<Movimiento_Pers>().NivelTotal;

        listado = GameObject.FindGameObjectsWithTag("Antagonista");
        contador = listado.Length;

        if (fase == 1)
        {
            jugador.GetComponent<Generador_enemigos>().CrearEnemigos(nivel1, fase);
            fase += 1;
        }

        if (progreso >= nivel1  && fase == 2)
        {
            jugador.GetComponent<Tiempo_Control>().Pausar();
            menu.SetActive(true);
            menu.GetComponent<Menu_Mejoras>().DarOpciones();

            jugador.GetComponent<Generador_enemigos>().CrearEnemigos(nivel2, fase);
            fase += 1;
        }

        if (progreso >= (nivel1 + nivel2) && fase == 3)
        {
            jugador.GetComponent<Tiempo_Control>().Pausar();
            menu.SetActive(true);
            menu.GetComponent<Menu_Mejoras>().DarOpciones();

            jugador.GetComponent<Generador_enemigos>().CrearEnemigos(nivel3, fase);
            fase += 1;
        }

        if (progreso >= (nivel1 + nivel2 + nivel3) && fase == 4)
        {
            jugador.GetComponent<Tiempo_Control>().Pausar();
            menu.SetActive(true);
            menu.GetComponent<Menu_Mejoras>().DarOpciones();

            jugador.GetComponent<Generador_enemigos>().CrearEnemigos(nivelfinal, fase);
            fase += 1;
        }

        if (progreso == 34 && fase == 5)
        {
            fase += 1;
        }

        

        if (fase == 6 && contador == 0)
        {
            barra.SetActive(false);
            jugador.GetComponent<Generador_enemigos>().CrearEnemigos(1, fase);
            fase += 1;

        }
    }
}
