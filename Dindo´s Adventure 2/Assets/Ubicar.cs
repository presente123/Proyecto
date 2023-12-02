using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicar : MonoBehaviour
{
    [SerializeField] Transform Jugador;

    [SerializeField] Transform objetivo;

    public GameObject jug;
    public GameObject jefe;
    public float velocidad_enemigo = 2f;
    private float vel;
    private int put;
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
        vel = jug.GetComponent<Movimiento_Pers>().velocidad;
        put = jug.GetComponent<Movimiento_Pers>().NivelTotal;

        if (objetivo == null)
        {
            objetivo = transform;
        }
        
        if (vel == 4f && put >= 30)
        {
            velocidad_enemigo += 2.4f;
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
