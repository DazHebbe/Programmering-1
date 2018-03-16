using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble; 
        //Sätter så att asteroiderna roterar olika varje gång och så att man kan sätta hur snabbt de roterar.
    }
}