using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    public GameObject jefe;
    public GameObject para;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (jefe.activeInHierarchy == false)
        {
            para.SetActive(false);
        }
    }
}
