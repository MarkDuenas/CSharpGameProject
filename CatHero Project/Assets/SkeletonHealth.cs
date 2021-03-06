﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public int currentHealth;   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("TakeDamage");
        FindObjectOfType<AudioManager>().Play("BoneBreak");


        if(currentHealth <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        animator.SetBool("Dead", true);
        GetComponent<Collider2D>().enabled = false;
        

        // Vector3 newPosition = minotaur.transform.position;
        // newPosition.y = 3f;
        // minotaur.localPosition = new Vector2(237f, -3f);

        this.enabled = false;
    }
}
