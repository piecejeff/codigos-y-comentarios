using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedrun;
    public SpriteRenderer sprite;
    public float JumpForce;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = false;
            rb.velocity = new Vector2(speedrun, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = true;
            rb.velocity = new Vector2(-speedrun, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);

        }
    }
}