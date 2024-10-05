using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public /*abstract*/ class PlayableCharacter : MonoBehaviour/*, IDamageable*/
{

    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;

    void Update()
    {

        Movement();

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        //Crouch();
    }

    private void Movement()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }


    private void Crouch()
    {
        //if we want the character to crouch
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false; 
        }
    }

    void FixedUpdate()
    {
       //Move our character
       controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
       jump = false; // To make sure the player jumps only once
    }

    //protected abstract void SpecialAbility();
}
