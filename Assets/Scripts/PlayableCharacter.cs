using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class PlayableCharacter : MonoBehaviour
{
    public CharacterController2D controller;
    [SerializeField] private Image powerImage;
    [SerializeField] private SpriteRenderer characterSprite;

    protected float horizontalMove = 0f;

    public float runSpeed = 55f;

    protected bool jump = false;
    protected bool crouch = false;

    public bool takeDamage;
    private int flickerAmount = 3;
    private float flickerDuration = 0.1f;

    private void Start()
    {
        Spikes.AddOnTakeDamageEventListener(Flash);
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

        //Crouch();
    }

    private void OnDisable()
    {
        if (powerImage)
            powerImage.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        powerImage.gameObject.SetActive(true);
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

    private void Flash(int damageTaken, Vector2 knockbackForce)
    {
        if(gameObject.activeSelf)
            StartCoroutine(DamageFlicker());
    }

    IEnumerator DamageFlicker()
    {
        for (int i = 0; i < flickerAmount; i++)
        {
            characterSprite.color = new Color(1f, 0f, 0f, 0.9f);
            yield return new WaitForSeconds(flickerDuration);
            characterSprite.color = Color.white;
            yield return new WaitForSeconds(flickerDuration);
        }
        
    }

    protected abstract void SpecialAbility();



}
