using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed; //Jag ger projektilen en fart beroende på vad jag skriver i Unity.
    }
}


