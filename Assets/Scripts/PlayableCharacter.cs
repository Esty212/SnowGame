using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class PlayableCharacter : MonoBehaviour, IDamageable
{

    public CharacterController2D controller;

    protected float horizontalMove = 0f;

    public float runSpeed = 40f;

    [SerializeField] protected bool jump = false;
    protected bool crouch = false;

    [SerializeField] protected int maxHp = 3;
    [SerializeField] protected int currentHp;

    //protected bool isAlive = true;
    //public Vector3 _lastSafePosition;

    private void Start()
    {
        currentHp = maxHp;
    }


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

        /*if (controller.m_Grounded)
        {
            _lastSafePosition = transform.position;
        }*/

        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 1f;
            Die();
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
        //if spikes touch player or player falls to river, damage -=1. 
        if (currentHp > 0)
        {
                currentHp -= damageTaken;
                Debug.Log("You fell.");
        }
        else if (currentHp <= 0)
        {
            Die();
        }     
        
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        currentHp = 3;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border") || collision.gameObject.CompareTag("Spikes"))
        {
            TakeDamage(1);
        }
    }

}
