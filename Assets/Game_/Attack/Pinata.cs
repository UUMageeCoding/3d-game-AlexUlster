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
    public float smoldelay;

    public Rigidbody pinata;       
    public float knockbackforce = 8f;

    public Transform particlepos;

    public GameObject particle;

    public ScoreManager score;
    


    void Awake()
    {
        

        currentHealth = maxHealth;
    }

  

    public void TakeDamage(int amount, Vector3 hitDirection) 
    {

       score.addscore();

        currentHealth -= amount;

        if (pinata != null)
        {
            pinata.AddForce(hitDirection.normalized * knockbackforce, ForceMode.Impulse);
        }

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
        Destroy(gameObject);
    }
}
