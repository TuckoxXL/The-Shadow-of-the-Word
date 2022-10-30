using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{
    [SerializeField]

    public int da�o; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().vida -= da�o;
        }
    }
}
