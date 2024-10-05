using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour, IDamageable
{

    public CharacterController2D controller;

    protected float horizontalMove = 0f;

    public float runSpeed = 40f;

    [SerializeField] protected bool jump = false;
    protected bool crouch = false;

    protected int maxMp = 5;
    protected int currentHp;


    protected virtual void Update()
    {
        Movement();

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SpecialAbility();
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

    protected virtual void FixedUpdate()
    {
       //Move our character
       controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
       jump = false; // To make sure the player jumps only once
    }

    protected abstract void SpecialAbility();

    public void TakeDamage(int damageTaken)
    {
        throw new System.NotImplementedException();
    }

    public void Die()
    {
        if (currentHp <= 0)
        {
            currentHp = 0;
            Debug.Log("You died.");

        }
    }
}
