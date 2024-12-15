using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptest : MonoBehaviour
{
    // Start is called before the first frame update

  //public PlayerData Data;

    [Header("Movement")]
    private Rigidbody2D rb;
    private Animator anim;
    public float walkSpeed;


    [Header("Jump")]
    private bool Grounded;
    public float JumpSpeed;
    public Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * walkSpeed, rb.velocity.y);

        // Flips sprite
        if(horizontalInput > 0.01f)
        {
           transform.localScale =new Vector3(1, 1, 1);
        }
        else if(horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        // calls jump
       if (Input.GetKey(KeyCode.Space) && Grounded)
            Jump();


        anim.SetBool("Walk", horizontalInput != 0);
        anim.SetBool("Grounded", Grounded);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, JumpSpeed + 2);
        Grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("working");
            Grounded = true;
        }


    }


}