using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour
{

    public GameObject Minion;
    public float rango = 13f;
    public float rango_x ;
    public float rango_y ;
    private Vector2 radio;
    private int distanciaX;
    private int distanciaY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame   Random.Range(-5f, 5f)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            do {
                rango_x = this.transform.position.x + Random.Range(-15.10f, 15.10f);
                rango_y = this.transform.position.y + Random.Range(-15.10f, 15.10f);
            }
            while (rango < rango_x && rango_x < (rango*-1) && rango < rango_y && rango_y < (rango * -1));
            Instantiate(Minion, new Vector2(this.transform.position.x + Random.Range(-15.10f, 15.10f), this.transform.position.y + Random.Range(-15.10f, 15.10f)), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            radio = Random.insideUnitCircle * 5;

            if (radio.x >= 0)
            {
                distanciaX = 1;
            }
            else
            {
                distanciaX = -1;
            }

            if (radio.y >= 0)
            {
                distanciaY = 1;
            }
            else
            {
                distanciaY = -1;
            }

            Instantiate(Minion, new Vector2(radio.x + this.transform.position.x + (6 * distanciaX), radio.y + this.transform.position.y + (6 * distanciaY)), Quaternion.identity);
        }
    }
}
