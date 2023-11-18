using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimiento_Pers : MonoBehaviour
{
    public GameObject jugador;
    public GameObject Pared;
    public RawImage Fondo;
    public float velocidad = 1f;
    public float ejex = 0;
    public float ejey = 0;
    public int LímiteVida = 3;
    public int Vida;
    public int NivelTotal;

    // Start is called before the first frame update
    public void RecibirDaño(int daño)
    {
        Vida -= daño;

        if (Vida <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Destroy(jugador);
        }
    }

    public void SumarPuntos(int puntos)
    {
        NivelTotal += puntos;
    }

    void Start()
    {
       transform.position = new Vector2(ejex, ejey);
       Vida = LímiteVida;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x + velocidad * Time.deltaTime, this.transform.position.y);
            Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo(velocidad,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x - velocidad * Time.deltaTime, this.transform.position.y);
            Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo((velocidad * -1), 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + velocidad * Time.deltaTime);
            Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo(0, velocidad);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y - velocidad * Time.deltaTime);
            Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo(0, (velocidad * -1));
        }

        if (Input.GetKey(KeyCode.P))
        {
            jugador.GetComponent<Tiempo_Control>().Pausar();
        }

        if (Input.GetKey(KeyCode.O))
        {
            jugador.GetComponent<Tiempo_Control>().Reanudar();
        }

        if (Input.GetKey(KeyCode.K)) {
            Pared.SetActive(false);
        }

        if (Input.GetKey(KeyCode.L)) {
            Pared.SetActive(true);
        }

    }

}
