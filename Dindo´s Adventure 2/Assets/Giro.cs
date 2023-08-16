using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{

    [SerializeField] Transform objetivo;

    void Rotacion()
    {
        Vector3 posicion_de_mou = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicion_de_mou.z = 0;

        Vector3 mirar = posicion_de_mou - objetivo.position;
        objetivo.right = mirar;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (objetivo == null)
        {
            objetivo = transform;
        }

        Rotacion();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
