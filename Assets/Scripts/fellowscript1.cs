using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class fellowscript1 : MonoBehaviour
{
// 2D Platformer movement code Modified by Melanie Stegman from this:
// https://stackoverflow.com/questions/62334560/how-do-i-keep-a-constant-velocity-in-unity-2d
// Only running left and right and jumping up on Y, not ading any force on Y with AddForce
// Maximum horizontal Velocity Management built in

private Rigidbody2D PlayerTwoRB2D;
public float MoveSpeed = 5f;
public float MaximumVelocity = 5f;
public float JumpVelocity = 1f;

public string Horizontal;

public logicscript logic;

public string Jump;

public bool Isgrounded;

public bool Airborne;

public bool Jumpstart;

public bool Walkstart;

public bool Walking;

public float x;

public bool fellowalive;



// For GroundChecking


public Animator fellowcontroller;

 public GameObject Canvas;




void Start()
{
PlayerTwoRB2D = GetComponent<Rigidbody2D>();// the RB2D on the attached GO
fellowcontroller = GetComponent<Animator>();
}

void OnCollisionEnter2D(Collision2D other)
{
  print(gameObject.name + " just hit the : " + other.gameObject.name);


 

  if(other.gameObject.CompareTag("Ground"))
  {
    fellowcontroller.SetBool("Isgrounded", true);
    fellowcontroller.SetBool("Airborne", false);
    Isgrounded = true;
    Airborne = false;
      print("Airborne = false");
    print("Isgrounded = true");
  }
 
 if(other.gameObject.layer == LayerMask.NameToLayer("pleasework"))
 {
   logic.gameOver();
  }

} 

 
// Update is called once per frame
void Update()
{
  print(Horizontal);
        if(Input.GetAxisRaw(Horizontal) == 1)

            {  
                PlayerTwoRB2D.AddForce(Vector2.right * MoveSpeed, ForceMode2D.Force);
                    fellowcontroller.SetBool("Walkstart", true);
                    Walkstart = true;
                      print("Walkstart = true");
                    print("right was pressed!");
                    x = 6f;

            }
            else if(Input.GetAxisRaw(Horizontal) == -1 && PlayerTwoRB2D.velocity.x >= -MaximumVelocity)
            {
                PlayerTwoRB2D.AddForce(Vector2.right * -MoveSpeed, ForceMode2D.Force);
                    fellowcontroller.SetBool("Walkstart", true);
                    Walkstart = true;
                      print("Walkstart = true");
                    print("left was pressed!");
                    x= -6f;
            }
        else 
        {
            fellowcontroller.SetBool("Walkstart", false);
            Walkstart = false;
              print("Walkstart = false");
              x = 0f;
              
            }




        // Jumping
         if((Input.GetAxisRaw(Jump) == 1) && (Airborne == false))
            {
                
                print ("jump attempted");
                    PlayerTwoRB2D.velocity = Vector2.up * JumpVelocity;
        
                    fellowcontroller.SetBool("Jumpstart", true);
                    Jumpstart = true;
                    print("Jumpstart = true");
                    Isgrounded = false;
                    fellowcontroller.SetBool("Isgrounded", false);
                    print("Isgrounded = false");
            } 



            if(Jumpstart == true)
{
    print ("in jumpstart");
    fellowcontroller.SetBool("Airborne", true);
                    Airborne = true;
                    fellowcontroller.SetBool("Isgrounded", false);
                    Isgrounded = false;
                    print("Airborne = true");
                     
                     print("Isgrounded = false");
}
            if(Airborne == true)
            {
            Isgrounded = false;
            fellowcontroller.SetBool("Isgrounded", false);
   print("Isgrounded = false");
}


if(PlayerTwoRB2D.velocity.y != 0)
            {
fellowcontroller.SetBool("Jumpstart", false); 
fellowcontroller.SetBool("Airborne", true); 
Jumpstart = false;
Airborne = true;
Isgrounded = false;
print("Jumpstart = false");
print("Airborne = true");
print("Isgrounded = false");
}

if(PlayerTwoRB2D.velocity.y == 0)
            {

fellowcontroller.SetBool("Airborne", false); 
Airborne = false;
print("Airborne = false");
}


if(PlayerTwoRB2D.velocity.x != 0)
            {
fellowcontroller.SetBool("Walking", true); 
Walking = true;
print("Walking = true");
}

if(PlayerTwoRB2D.velocity.x == 0)
{
    fellowcontroller.SetBool("Walking", false); 
    Walking = false;
print("Walking = false");
}
       



}




}