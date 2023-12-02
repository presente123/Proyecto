using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    public GameObject jefe;
    public GameObject jugador;
    private float vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = jugador.GetComponent<Movimiento_Pers>().velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
