using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicar : MonoBehaviour
{
    [SerializeField] Transform Jugador;

    [SerializeField] Transform objetivo;

    public float velocidad_enemigo = 2f;
    public Vector3 posicionamiento;

    void Rotacion()
    {
        Vector3 posicion_de_J1 = posicionamiento;
        posicion_de_J1.z = 0;

        Vector3 mirar = posicion_de_J1 - objetivo.position;
        objetivo.right = mirar;
    }

    // Start is called before the first frame update
    void Start()
    {
        velocidad_enemigo = 2f;

        if (objetivo == null)
        {
            objetivo = transform;
        }

        if (Jugador.GetComponent<Movimiento_Pers>().NivelTotal == 34)
        {
            velocidad_enemigo = Jugador.GetComponent<Movimiento_Pers>().velocidad += 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        posicionamiento = Jugador.position;

        Rotacion();

        this.transform.Translate(Vector3.right * velocidad_enemigo * Time.deltaTime, Space.Self);
    }
}
