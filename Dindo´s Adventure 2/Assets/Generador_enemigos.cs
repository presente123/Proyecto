using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour
{

    public GameObject Minion;
    public float rango = 13f;
    public float rango_x ;
    public float rango_y ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame   Random.Range(-5f, 5f)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            do {
                rango_x = this.transform.position.x + Random.Range(-15.10f, 15.10f);
                rango_y = this.transform.position.y + Random.Range(-15.10f, 15.10f);
            }
            while (rango < rango_x && rango_x < (rango*-1) && rango < rango_y && rango_y < (rango * -1));
            Instantiate(Minion, new Vector2(this.transform.position.x + Random.Range(-15.10f, 15.10f), this.transform.position.y + Random.Range(-15.10f, 15.10f)), Quaternion.identity);
        }
    }
}
