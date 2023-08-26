using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_bala : MonoBehaviour
{

    [SerializeField] private float tiempo_de_vida = 10f;

    public float velocidad_bala = 2f;

    public GameObject Bala;
    private BoxCollider2D cola;

    public int daño = 5;

    void Disparar()
    {
        //cola = Bala.GetComponent<BoxCollider2D>();
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
            Destroy(Bala);
        }
    }
}
