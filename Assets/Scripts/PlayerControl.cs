using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 7;
    public bool slide;
    public float drag = 2f;

    private Vector2 direction;
    private Rigidbody2D rb2d;

    public logicscript logic;

    public bool fellowalive;

    private void Start()
    {
        gameObject.tag = "Player";
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (!slide)
        {
            rb2d.drag = 0;
            rb2d.velocity = Vector2.zero;
        }
        else
        {
            rb2d.drag = drag;
        }
        
        rb2d.AddForce(direction * speed, ForceMode2D.Impulse);
            }

//if collider collides with balloon, delete this gameobject and create win screen


//   private void OnCollisionEnter2D(Collision2D collision)
//     {
//         logic.gameOver();
//         fellowalive = false;
//     }

}
