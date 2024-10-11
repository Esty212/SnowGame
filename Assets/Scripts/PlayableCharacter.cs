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

    [SerializeField] protected int maxHp = 3;
    [SerializeField] protected int currentHp;

    protected bool isAlive = true;
    private float _fallBorder;
    public Vector3 _lastSafePosition;

    private void Start()
    {
        _fallBorder = GameObject.Find("FallBorder").transform.position.y;
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

        if (transform.position.y < _fallBorder)
        {
            Respawn();
            TakeDamage(1);

        }
        else if (controller.m_Grounded)
        {
            _lastSafePosition = transform.position;
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
        if (isAlive)
        {
                currentHp -= damageTaken;
                Debug.Log("You fell.");
        }
        else
        {
            Die();
        }
            
        
    }

    public void Die()
    {
        if (currentHp <= 0)
        {
            currentHp = 0;
            isAlive = false;
            Debug.Log("You died.");

        }
    }

    protected void Respawn()
    {
        transform.position = _lastSafePosition;
    }
}
