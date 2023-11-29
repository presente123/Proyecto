using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eleccion_PU : MonoBehaviour
{
    public float rango = 20f;
    public float limit = 15f;
    public float x;
    public float y;

    public void AAA()
    {
        do
        {
            x = Random.Range(-rango, rango);
        }
        while (limit < x || x < -limit);

        do
        {
            y = Random.Range(-rango, rango);
        }
        while (limit < y || y < -limit);

        Debug.Log(x);
        Debug.Log(y);
    }

    public void Roberto()
    {
        Debug.Log("si");
    }

    public void Carlos()
    {
        Debug.Log("no");
    }


}
