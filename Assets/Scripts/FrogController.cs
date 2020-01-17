﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    public float waitToJump = 5.0f;
    public float jumpForce = 400f;
    public Rigidbody2D rigidBody;
    public Animator animator;

    protected virtual void Start()
    {
        StartCoroutine(WaitAndJump());
    }

    IEnumerator WaitAndJump()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitToJump);
            animator.SetBool("IsJumping", true);
            rigidBody.AddForce(new Vector2(0, jumpForce));
        }
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("IsJumping", false);
    }
}
