using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambiar_Menu : MonoBehaviour
{
    public Image Fondo;
    public Sprite nuevaSig;
    public Sprite nuevaAnt;

    void Start()
    {
        nuevaSig = Resources.Load<Sprite>("tuto");
        nuevaAnt = Resources.Load<Sprite>("tuto2");
    }

    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Volver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void VolverInicioMM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void VolverInicioT()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void VolverInicioV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void LlevarTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void TutoSig()
    {
        Fondo.sprite = nuevaSig;
    }

    public void TutoAnt()
    {  
        Fondo.sprite = nuevaAnt;
    }

    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
