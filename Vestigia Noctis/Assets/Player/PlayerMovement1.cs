using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private Vector2 moveDirection;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        

        //moveDirection = new Vector2(movement.x, movement.y).normalized;
        
        /*
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        */
        if (Input.GetAxisRaw("Horizontal") == 1 ||
           Input.GetAxisRaw("Horizontal") == -1 ||
           Input.GetAxisRaw("Vertical") == 1 ||
           Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("Last_Horizontal",
                              Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("Last_Vertical",
                              Input.GetAxisRaw("Vertical"));
        }
        /*
        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetBool("isAttack", true);

        */
    }

    void FixedUpdate()
    {
       /* 
        if (animator.GetBool("isAttack") == true)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.MovePosition(rb.position + movement * moveSpeed *
                            Time.fixedDeltaTime);
        }

        if (animator.GetBool("isAttack") == true && animator.GetFloat("Last_Horizontal") < 0)
        {
            ataqueIzq.SetActive(true);
           
        }
        

        if (animator.GetBool("isAttack") == true && animator.GetFloat("Last_Horizontal") > 0)
        {
            ataqueDer.SetActive(true);
        }
            
        


        if (animator.GetBool("isAttack") == true && animator.GetFloat("Last_Vertical") < 0)
        {
            ataqueDelante.SetActive(true);
        }

            
        

        if (animator.GetBool("isAttack") == true && animator.GetFloat("Last_Vertical") > 0)
        {
            ataqueAtras.SetActive(true);
        }
            
        */


    }

    void StopAttack()
    {
        /*
        ataqueIzq.SetActive(false);
        ataqueDer.SetActive(false);
        ataqueDelante.SetActive(false);
        ataqueAtras.SetActive(false);

        if (animator.GetBool("isAttack"))
            animator.SetBool("isAttack", false);
        */
    }
}
