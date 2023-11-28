using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour
{
    public GameObject jugador;
    public GameObject Minion;
    public float rango = 10f;
    public float rango_x ;
    public float rango_y ;
    private Vector2 posicion;
    private int Signo_x; 
    private int Signo_y;
    private List<int> Valores = new();

    public void CrearEnemigos(int cantidad)
    {
        for(int i = 0; i < cantidad; i++) { 
            do
            {
                rango_x = this.transform.position.x + Random.Range(-15.10f, 15.10f);
                rango_y = this.transform.position.y + Random.Range(-15.10f, 15.10f);
            }

            while (rango < rango_x && rango_x < (rango * -1) && rango < rango_y && rango_y < (rango * -1));

            posicion = new Vector2(this.transform.position.x + Random.Range(-15.10f, 15.10f), this.transform.position.y + Random.Range(-15.10f, 15.10f));

            Instantiate(Minion, posicion, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Valores.Add(-1);
        Valores.Add(1);
    }

    // Update is called once per frame   Random.Range(-5f, 5f)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            do {
                rango_x = this.transform.position.x + Random.Range(-15.10f, 15.10f);
                rango_y = this.transform.position.y + Random.Range(-15.10f, 15.10f);
            }
            while (rango < rango_x && rango_x < (rango*-1) && rango < rango_y && rango_y < (rango * -1));
            Instantiate(Minion, new Vector2(this.transform.position.x + Random.Range(-15.10f, 15.10f), this.transform.position.y + Random.Range(-15.10f, 15.10f)), Quaternion.identity);
        
            /*
            radio = Random.insideUnitSphere;
            posicion = radio + Minion.GetComponents<Ubicar>().po
            Instantiate(Minion, radio * 5, Quaternion.identity);*/
        }
        
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rango_x =  Random.Range(00.00f, 15.00f) ;
            rango_y =  Random.Range(00.00f, 15.00f) ;

            Signo_x = Random.Range(0, 1);
            Signo_y = Random.Range(0, 1);

            Instantiate(Minion, new Vector2(jugador.transform.position.x + (rango_x  * Valores[Signo_x]), jugador.transform.position.y + (rango_y * Valores[Signo_y])), Quaternion.identity);
        }
    }
}
