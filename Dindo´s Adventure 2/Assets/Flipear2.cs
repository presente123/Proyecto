using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipear2 : MonoBehaviour
{
    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = false;
        }
            

        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = true;
        }
            
    }
}