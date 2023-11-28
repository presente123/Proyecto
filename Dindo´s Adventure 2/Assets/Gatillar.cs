using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatillar : MonoBehaviour
{

    public GameObject Bala;
    public GameObject Minion;

    //public int 

    // Start is called before the first frame update
    void Start()
    {
        Bala.GetComponent<Movimiento_bala>().RestablecerValores();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion_de_mous = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bala, new Vector2( this.transform.position.x, this.transform.position.y) , Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("creando");
            Instantiate(Minion, new Vector2(posicion_de_mous.x, posicion_de_mous.y), Quaternion.identity);
        }

    }
}
