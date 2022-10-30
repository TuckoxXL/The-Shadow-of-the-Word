using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScrip : MonoBehaviour
{

    public Door doortoOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doortoOpen.isUnlocket = true;
        }

        Destroy(gameObject);
    }
    
}
