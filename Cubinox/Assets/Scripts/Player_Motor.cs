using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Motor : MonoBehaviour
{
    public enum States { blackey, whitey}

    public States currentColor;

    int colorLayer;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public float fallForce;
    public float howHigh;
    public float jumpForce;
    public float speed;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        currentColor = States.blackey;
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
    }

    private void Update()
    {
        ChangeState();
        Jump();
        FlipSprite();

        if (rb.velocity.y < 0)
            rb.velocity += Vector2.up * Physics2D.gravity.y * fallForce * Time.deltaTime;
        else if (rb.velocity.y > 0)
            rb.velocity += Vector2.up * Physics2D.gravity.y * howHigh * Time.deltaTime;

        switch (currentColor)
        {
            case States.blackey:
                colorLayer = LayerMask.GetMask("Black_Tile");
                sr.sprite = sprites[0];
                gameObject.layer = 8;
                break;
            case States.whitey:
                colorLayer = LayerMask.GetMask("White_Tile");
                sr.sprite = sprites[1];
                gameObject.layer = 9;
                break;
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 0.6f, colorLayer))
            {
                rb.AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentColor != States.blackey)
                currentColor = States.blackey;
            else
                currentColor = States.whitey;
        }
    }

    void FlipSprite()
    {
        if (Input.GetAxis("Horizontal") > 0)
            sr.flipX = false;
        else if (Input.GetAxis("Horizontal") < 0)
            sr.flipX = true;
    }
}
