using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatillar : MonoBehaviour
{

    public GameObject Bala;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bala, new Vector2( this.transform.position.x, this.transform.position.y) , Quaternion.identity);
        }


    }
}
