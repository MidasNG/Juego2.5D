using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControls : MonoBehaviour
{
    private float speed = 5, moveInput, jumpPower = 5;
    private Rigidbody rb;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        if (moveInput > 0)
        {
            animator.SetBool("runningBack", false);
            animator.SetBool("runningFront", true);
            rb.velocity = new Vector3(moveInput * speed, rb.velocity.y, 0);
        }
        else if (moveInput < 0)
        {
            animator.SetBool("runningFront", false);
            animator.SetBool("runningBack", true);
            rb.velocity = new Vector3(moveInput * speed, rb.velocity.y, 0);
        }
        else
        {
            animator.SetBool("runningBack", false);
            animator.SetBool("runningFront", false);
        }
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<float>();
    }

    private void OnJump()
    {
        animator.SetTrigger("jump");
    }
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpPower, 0);
    }

    private void OnShoot()
    {
        animator.SetTrigger("shoot");
    }
}
