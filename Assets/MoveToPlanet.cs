using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlanet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(500,0,285);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
