using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManeuver : MonoBehaviour {

    public float dodge;
    public float smoothing;
    public float tilt;

    public Vector2 startWait;
    public Vector2 maneuverTime;
    public Vector2 maneuverWait;

    public Boundary boundary;

    private float currentSpeed;
    private float targetManeuver;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity.z;
        StartCoroutine(Evade()); // Starta Evade.
    }

    IEnumerator Evade()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y)); // Inom en tid jag sätter Vänta.

        while (true)
        {
            targetManeuver = Random.Range(1, dodge) * -Mathf.Sign(transform.position.x); //Inom en range mellan 1 och ett nummer jag sätter, rör fienden i X axisesn.
            yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y)); // Inom en tid jag sätter Väja.
            targetManeuver = 0; //Sätt targetManeuver till 0.
            yield return new WaitForSeconds(Random.Range(maneuverWait.x, maneuverWait.y)); // Inom en tid jag sätter Vänta.
        }
    }

    void FixedUpdate()
    {
        float newManeuver = Mathf.MoveTowards(rb.velocity.x, targetManeuver, Time.deltaTime * smoothing); // Ett kommando som gör så att skeppet är mindre hackigt när det väjar.
        rb.velocity = new Vector3(newManeuver, 0.0f, currentSpeed);
        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax) // Håll skeppet inom Boundarys område.
        );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt); // Tilta skeppet när det svänger.
    }
}
