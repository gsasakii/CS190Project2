﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellScript : MonoBehaviour {
     public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
          rb.AddForce(transform.right * 500);
	}
	
	// Update is called once per frame
	void Update () {
          
	}
}
