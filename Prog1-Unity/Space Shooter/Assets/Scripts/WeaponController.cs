using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate); // Limiterar hur snabbt man kan skjuta.
    }

    void Fire ()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation); //Instantiera ett skott och spela ett ljud.
        audioSource.Play();
    }
}
