using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Mejoras : MonoBehaviour
{
    private string Opcion1;
    private string Opcion2;
    public List<string> PowerUps = new();

    public string Seleccionar()
    {
        int r = Random.Range(0, PowerUps.Count);
        string con = PowerUps[r];
        PowerUps.RemoveAt(r);
        return con;
    }

    void Start()
    {
        PowerUps.Add("VelocidadDeBala");
        PowerUps.Add("VelocidadDelJugador");
        PowerUps.Add("DañoDeBala");
        PowerUps.Add("VidaDelJugador");
        PowerUps.Add("aaaa");
        PowerUps.Add("bbbb");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {

            Seleccionar();

        }
    }


}
