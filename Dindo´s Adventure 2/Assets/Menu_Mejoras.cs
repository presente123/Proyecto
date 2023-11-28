using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Menu_Mejoras : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bala;
    public GameObject menu;
    
    public Image boton1;
    public Image boton2;
    public Sprite nuevaIB1;
    public Sprite nuevaIB2;

    public string Opcion1;
    public string Opcion2;
    private List<string> PowerUps = new();
    public List<string> PowerUpsTemporal = new();

    public string Seleccionar()
    {
        int maxi = PowerUpsTemporal.Count;
        maxi -= 1;
        int r = Random.Range(0, maxi);
        string con = PowerUpsTemporal[r];
        PowerUpsTemporal.RemoveAt(r);
        return con;
    }

    void Start()
    {
        PowerUps.Add("VelocidadDeBala");
        PowerUps.Add("VelocidadDelJugador");
        PowerUps.Add("DañoDeBala");
        PowerUps.Add("VidaDelJugador");
        PowerUps.Add("TamañoDeBala");
        PowerUps.Add("TamañoDelJugador");

        PowerUpsTemporal = new List<string>(PowerUps);
    }

    void Update()
    {

    }

    public void DarOpciones()
    {
        Opcion1 = Seleccionar();

        Opcion2 = Seleccionar();


        nuevaIB1 = Resources.Load<Sprite>(Opcion1);
        boton1.sprite = nuevaIB1;

        nuevaIB2 = Resources.Load<Sprite>(Opcion2);
        boton2.sprite = nuevaIB2;
    }

    public void Boton1()
    {
        Mejorar(Opcion1);
        jugador.GetComponent<Movimiento_Pers>().RestablecerVida();
        menu.SetActive(false);
        jugador.GetComponent<Tiempo_Control>().Reanudar();

    }

    public void Boton2()
    {
        Mejorar(Opcion2);
        jugador.GetComponent<Movimiento_Pers>().RestablecerVida();
        menu.SetActive(false);
        jugador.GetComponent<Tiempo_Control>().Reanudar();
    }

    void Mejorar(string mejora)
    {
        if (mejora == PowerUps[0])
        {
            bala.GetComponent<Movimiento_bala>().VelocidadDeBala();
        }        
        else if (mejora == PowerUps[1])
        {
            jugador.GetComponent<Movimiento_Pers>().VelocidadDelJugador();
        }
        else if (mejora == PowerUps[2])
        {
            bala.GetComponent<Movimiento_bala>().DañoDeBala();
        }
        else if (mejora == PowerUps[3])
        {
            jugador.GetComponent<Movimiento_Pers>().VidaDelJugador();
        }
        else if (mejora == PowerUps[4])
        {
            bala.GetComponent<Movimiento_bala>().TamañoDeBala();
        }
        else if (mejora == PowerUps[5])
        {
            jugador.GetComponent<Movimiento_Pers>().TamañoDelJugador();
        }

    }


}
