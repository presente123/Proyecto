using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimiento_Pers : MonoBehaviour
{
    public GameObject jugador;
    public Transform valoresJ;
    public GameObject Pared;
    public RawImage Fondo;
    public Canvas Inter;
    public SpriteRenderer spriteRenderer;
    public float velocidad = 2f ;
    public float ejex = 0;
    public float ejey = 0;
    public int LímiteVida = 3;
    public int Vida;
    public int NivelTotal;



    // Start is called before the first frame update
    public void Ganar() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void RestablecerValores()
    {
        velocidad = 2f;
        LímiteVida = 3;
        valoresJ.localScale = new Vector3(3.5f, 4.0f, 1.0f);
        RestablecerVida();

    }

    public void RestablecerVida()
    {
        Vida = LímiteVida;
    }

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

    public void VelocidadDelJugador()
    {
        velocidad += velocidad;
    }

    public void VidaDelJugador()
    {
        LímiteVida += (LímiteVida * 2);
    }


    public void TamañoDelJugador()
    {
        valoresJ.localScale = new Vector3(0.5f, 1.0f, 1.0f);
    }


    void Start()
    {
        GetComponent<Tiempo_Control>().Reanudar();
        transform.position = new Vector2(ejex, ejey);
        RestablecerValores();
    }

    // Update is called once per frame
    void Update()
    {
        if (Inter.isActiveAndEnabled == false) {
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.Self);
                //this.transform.position = new Vector2(this.transform.position.x + velocidad * Time.deltaTime, this.transform.position.y);
                Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo(velocidad, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.Self);
                //this.transform.position = new Vector2(this.transform.position.x - velocidad * Time.deltaTime, this.transform.position.y);
                Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo((velocidad * -1), 0);
            }

            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(Vector3.up * velocidad * Time.deltaTime, Space.Self);
                //this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + velocidad * Time.deltaTime);
                Fondo.GetComponent<Movimiento_Imagen>().Mover_fondo(0, velocidad);
            }

            if (Input.GetKey(KeyCode.S))
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
        }
        
        float HAxis = Input.GetAxisRaw("Horizontal");

        if (HAxis > 0)
        {
            spriteRenderer.flipX = true;
        } else if (HAxis < 0) {
            spriteRenderer.flipX = false;
        }

        if (NivelTotal >= 35)
        {
            Invoke("Ganar", 3);
        }
    }

}
