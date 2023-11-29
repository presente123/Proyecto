using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour
{
    public GameObject jugador;
    public GameObject Minion;
    public GameObject Pl;
    public GameObject Robot;
    public GameObject JF;
    private GameObject Enemigo;
    public float rango;
    public float rango_x ;
    public float rango_y ;

    private int aleatorio;

    public void CrearEnemigos(int cantidad, int Fase)
    {
        for(float i = 0; i < cantidad; i++) { 
            aleatorio = Random.Range(0, 4);

            if ( aleatorio == 0 )
            {
                rango_x = jugador.transform.position.x + rango + i;
                rango_y = jugador.transform.position.y + rango + i;
            }
            else if (aleatorio == 1)
            {
                rango_x = jugador.transform.position.x - rango - i;
                rango_y = jugador.transform.position.y + rango + i;
            }
            else if (aleatorio == 2)
            {
                rango_x = jugador.transform.position.x + rango + i;
                rango_y = jugador.transform.position.y - rango - i;
            }
            else if (aleatorio == 3)
            {
                rango_x = jugador.transform.position.x - rango - i;
                rango_y = jugador.transform.position.y - rango - i;
            }

            if (Fase == 1 || aleatorio == 0 && Fase != 6 || aleatorio == 3 && Fase != 6)
            {
                Enemigo = Minion;
            }
            else if (Fase != 1 && Fase != 6 && aleatorio == 1)
            {
                Enemigo = Pl;
            }
            else if (Fase != 1 && Fase != 6 && aleatorio == 2)
            {
                Enemigo = Robot;
            }
            else if (Fase == 6)
            {
                Enemigo = JF;
            }

            Instantiate(Enemigo, new Vector2(rango_x, rango_y), Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame   Random.Range(-5f, 5f)
    void Update()
    {

    }
}
