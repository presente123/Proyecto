using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatillar : MonoBehaviour
{

    public GameObject Bala;
    public Canvas Inter;
    public float CoolDown;

    //public int 
    private void CrearBala()
    {
        Instantiate(Bala, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        Bala.GetComponent<Movimiento_bala>().RestablecerValores();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicion_de_mous = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0) && (Inter.isActiveAndEnabled == false) && Time.timeScale == 1f)
        {
            Invoke("CrearBala", CoolDown);
        }

    }
}
