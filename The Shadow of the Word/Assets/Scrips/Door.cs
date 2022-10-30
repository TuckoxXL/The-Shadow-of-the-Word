using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    public bool isUnlocket = true;
    public float doorspeed = 1f;

    public Transform opentranform;
    public Transform closetranform;

    Vector3 targetposition;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        targetposition = closetranform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnlocket && door.position != targetposition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetposition, time);
            time += Time.deltaTime * doorspeed;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            targetposition = opentranform.position;
            time = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetposition = closetranform.position;
            time = 0;
        }
    }
}
