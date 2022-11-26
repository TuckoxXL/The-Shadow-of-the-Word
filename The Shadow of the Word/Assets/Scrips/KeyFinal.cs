using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFinal : MonoBehaviour
{
    public DoorFinal doorFinal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        
            doorFinal.isUnlocket = true;
        }

        Destroy(gameObject);
    }
}

