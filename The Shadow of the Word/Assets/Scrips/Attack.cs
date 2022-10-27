using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject filo;

    private void Start()
    {
        filo.GetComponent<BoxCollider>().isTrigger = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Animator>().SetTrigger("espadaaccion");
            filo.GetComponent<BoxCollider>().isTrigger = true;
            StartCoroutine(FinAtaque());
         
        }
    }
    IEnumerator FinAtaque()
    {
        yield return new WaitForSeconds(0.5f);
        filo.GetComponent<BoxCollider>().isTrigger =false;
    }
}
