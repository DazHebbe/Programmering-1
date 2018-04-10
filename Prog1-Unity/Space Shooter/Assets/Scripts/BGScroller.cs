using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

	// Use this for initialization
	void Start () {
        startPosition = transform.position; //Sätter startpositionen för våran bakrund.
	}
	
	// Update is called once per frame
	void Update () {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ); //Sätter positionen bakrunden ska scrolla till och hur snabbt den ska scrolla.
        transform.position = startPosition + Vector3.forward * newPosition; //Gör så att bakrunden scrollar till sin nya position.
	}
}
