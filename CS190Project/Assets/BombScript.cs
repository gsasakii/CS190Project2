using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
          gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 10f * Time.deltaTime, 0f);
	}
}
