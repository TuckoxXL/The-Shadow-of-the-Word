using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{

    [SerializeField]

    public int da�o; 
    public Animator animator;
    public GameObject enemigo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("colisiono");
            other.GetComponent<Enemy>().vida -= da�o;
            animator = other.GetComponent<Animator>();
            enemigo = other.gameObject;
            animator.SetTrigger("Dead");
            Invoke("DestroyEnemy", 4f);
        }
    }

    public void DestroyEnemy()
    {
        Destroy(enemigo);
    }
}
