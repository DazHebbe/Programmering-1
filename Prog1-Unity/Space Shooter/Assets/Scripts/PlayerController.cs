using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play ();
        } //Sätter upp så att man ändra i Unity hur snabbt man kan skjuta med sitt vapen.
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); //Jag gör en ny Vector3 för att kunna läsa värdena av rörelse.
        GetComponent<Rigidbody>().velocity = movement * speed; // Jag skriver kod som använder sig av värdena av rörelse för att kunna röra skeppet.

        GetComponent<Rigidbody>().position = new Vector3 //Jag gör en ny Vector3 för värdena om position, och använder det för att kunna limitera skeppet till spelområdet.
        (
            Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax) ,
            0.0f,
            Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt); // Gör så att skeppet tiltar när man åker åt sidorna.
    }
}
