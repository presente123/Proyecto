using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicar : MonoBehaviour
{
    [SerializeField] Transform Jugador;

    [SerializeField] Transform objetivo;

    public float velocidad_enemigo = 2f;

    void Rotacion()
    {
        Vector3 posicion_de_J1 = Jugador.position;
        posicion_de_J1.z = 0;

        Vector3 mirar = posicion_de_J1 - objetivo.position;
        objetivo.right = mirar;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (objetivo == null)
        {
            objetivo = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Rotacion();

        this.transform.Translate(Vector3.right * velocidad_enemigo * Time.deltaTime, Space.Self);
    }
}
