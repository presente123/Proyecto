using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Movimiento_Imagen : MonoBehaviour
{
    private float x_actual;
    private float y_actual;
    public float desplazamiento;
    public RawImage Fondo;
    public Canvas Inter;

    // Start is called before the first frame update
    void Start()
    {
        desplazamiento = 2000;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Mover_fondo(float x_nueva, float y_nueva)
    {

        if (Inter.isActiveAndEnabled == false && Time.timeScale == 1f)
        {
            x_actual = Fondo.uvRect.x;
            y_actual = Fondo.uvRect.y;

            x_actual += (x_nueva / desplazamiento);
            y_actual += (y_nueva / desplazamiento);

            Fondo.uvRect = new Rect(x_actual, y_actual, 1, 1);
        }
    }

}
