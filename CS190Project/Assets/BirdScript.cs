using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
     public GameObject tank;
     bool fly = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
          if (fly)
          {
               Debug.Log("flying");
               gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3f * Time.deltaTime,
                    gameObject.transform.position.y + 3f * Time.deltaTime, 0f);
          }
	}

     void OnTriggerEnter2D(Collider2D coll)
     {
          //Debug.Log("collision");
          if (coll.gameObject == tank)
          {
               fly = true;
          }
     }
}
