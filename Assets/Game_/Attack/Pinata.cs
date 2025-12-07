using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class Pinata : MonoBehaviour
{
    int currentHealth;
    public int maxHealth;

    public float delay;    

    public Transform particlepos;

    public GameObject particle;

    public ScoreManager score;

    public Transform player;

    public Animator pinataAnim;

    public int distanceNUMBER = 3;

    public GameObject exclamation;
    
    public GameObject questionmark;

    void Awake()
    {
        currentHealth = maxHealth;
        exclamation.SetActive(false);
        questionmark.SetActive(true);
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        
        if (distance < distanceNUMBER)
        {
            pinataAnim.Play("Pinata Scared");

            exclamation.SetActive(true);
            questionmark.SetActive(false);
        }
        else
        {
            pinataAnim.Play("PinataMovement");

            exclamation.SetActive(false);
            questionmark.SetActive(true);
        }
    }

    public void TakeDamage(int amount, Vector3 hitDirection) 
    {
       score.addscore();
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Invoke("Confetti", delay);
            
            Invoke("Death", delay);
        }
    }

    void Confetti()
    {
        Instantiate(particle, particlepos.transform);
    }

    void Death()
    {
        Destroy(exclamation);
        Destroy(questionmark);
        Destroy(gameObject);
    }
}
