using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipearr : MonoBehaviour
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
            body.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            spriteRenderer.flipX = body.velocity.x < 0f;
    }
}
