using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Pers : MonoBehaviour
{
    public float velocidad = 1f;
    public float ejex = 0;
    public float ejey = 0;


    // Start is called before the first frame update
    void Start()
    {
       transform.position = new Vector2(1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x + velocidad * Time.deltaTime, this.transform.position.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x - velocidad * Time.deltaTime, this.transform.position.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * velocidad * Time.deltaTime, Space.Self);
            //this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y - velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            //this.colliderToDisable.enabled = false;
        }
    }

}
