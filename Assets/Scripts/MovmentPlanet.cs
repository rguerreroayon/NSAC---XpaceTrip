﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlanet : MonoBehaviour {

    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime * speed);
	}
}
