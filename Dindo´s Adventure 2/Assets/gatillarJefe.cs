using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatillarJefe : MonoBehaviour
{

    public GameObject Bala;
    public float CoolDown;

    //public int 
    private void CrearBala()
    {
        Instantiate(Bala, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("CrearBala", CoolDown);
    }
}
