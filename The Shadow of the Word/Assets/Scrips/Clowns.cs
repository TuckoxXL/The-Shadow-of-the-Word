using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clowns : MonoBehaviour
{
    public Animator clowanimator;
    public int health; 

    void Start()
    {
        clowanimator = GetComponent<Animator>();
        health = 100;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sword"))
        {
            Debug.Log("SWORD YES");
            health -= 20;
            if (health < 0) 
            {
                clowanimator.SetTrigger("morir"); 
            }
            
        }
    }
}
