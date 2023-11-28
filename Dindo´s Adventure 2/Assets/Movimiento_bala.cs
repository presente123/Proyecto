using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_bala : MonoBehaviour
{

    [SerializeField] private float tiempo_de_vida = 5f;
    public float velocidad_bala = 2f;
    public GameObject Bala;
    public Transform valoresB;
    public int daño = 1;

    //void Disparar()
    //{
    //cola = Bala.GetComponent<BoxCollider2D>();
    //}
    public void RestablecerValores()
    {
        velocidad_bala = 4f;
        daño = 1;
        valoresB.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void VelocidadDeBala()
    {
        velocidad_bala += (velocidad_bala * 2);
    }

    public void DañoDeBala()
    {
        daño += (daño * 2);
    }
    public void TamañoDeBala()
    {
        valoresB.localScale = new Vector3(2f, 2f, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(Bala ,tiempo_de_vida);
    }

    // Update is called once per frame
    void Update()
    {

        Bala.transform.Translate(Vector3.right * velocidad_bala * Time.deltaTime, Space.Self);

        //this.transform.position = new Vector2(Bala.transform.position.x + velocidad_bala * Time.deltaTime, Bala.transform.position.y);
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Antagonista"))
        {
            collision.gameObject.GetComponent<Comportamiento_Enemigo>().RecibirDaño(daño);
            Destroy(Bala);
        }
    }
}
