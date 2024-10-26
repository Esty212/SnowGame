using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAndSoundEffects : MonoBehaviour
{

    private float horizontal;
    private float speed = 0f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform groundLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("horizontal"); // applying for right left arrows movements
    }

    private void FixedUpdates()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void IsGrounded()
    {
        //return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); // to check if we are grounded
    }                                                       //creates an invisible circle right at our players feet and when collides with groundlayer it allows us to jump
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScal = transform.localScale;
            localScal.x *= -1f;
            transform.localScale = localScal;
        }
    }
}
