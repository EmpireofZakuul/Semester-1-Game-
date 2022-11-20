using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayerMovment : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private SpriteRenderer playerSprite;

    private float dirX = 0f;
    public float playerSpeed;

    private float dirXRight = 1f;
    private float dirXLeft = -1f;

    public bool PMovesRight = false;
    public bool PMovesLeft = false;

    public float P_BigJumpForce;
    public bool P_isGrounded;
    private bool P_isDead = false;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

       // P_Anim = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    public void Jump()
    {
        if (P_isGrounded == true)
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, P_BigJumpForce);

            //_Anim.SetTrigger("IsJumping");
           // P_Anim.SetBool("IsRunning", false);

           // P_JumpSFX.Play();
        }
    }

    public void MoveRight()
    {
        PMovesRight = true;
        PMovesLeft = false;
       // P_Anim.SetBool("IsRunning", true);
        //P_Anim.SetBool("IsIdle", false);
    }

    public void MoveLeft()
    {
        PMovesLeft = true;
        PMovesRight = false;
        //P_Anim.SetBool("IsRunning", true);
       // P_Anim.SetBool("IsIdle", false);
    }

    public void StopMoving()
    {
        PMovesLeft = false;
        PMovesRight = false;
       // P_Anim.SetBool("IsRunning", false);
        //P_Anim.SetBool("IsIdle", true);
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        playerRigidbody.velocity = new Vector2(dirX * playerSpeed, playerRigidbody.velocity.y);
                
        if (Input.GetButtonDown("Jump") && P_isDead == false)
        {
            Jump();
        }
        
        //checks that the player is not dead, and then 
        if (PMovesRight == true && P_isDead == false)
        {
            playerRigidbody.velocity = new Vector2(dirXRight * playerSpeed, playerRigidbody.velocity.y);
            //P_Anim.SetBool("IsRunning", true);
        }
        if (PMovesLeft == true && P_isDead == false)
        {
            playerRigidbody.velocity = new Vector2(dirXLeft * playerSpeed, playerRigidbody.velocity.y);
           // P_Anim.SetBool("IsRunning", true);
        }


        if (playerRigidbody.velocity.x > 0f)
        {
            playerSprite.flipX = false;
        }
        if (playerRigidbody.velocity.x < 0f)
        {
            playerSprite.flipX = true;
        }
      
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && P_isDead == false)
        { 
            P_isGrounded = false;
        }
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && P_isDead == false)
        {
            P_isGrounded = true;
        }
    }
}