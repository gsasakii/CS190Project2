using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

     public GameObject shell;
     bool fired = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
          if (Input.GetKey("w"))
          {
               if(gameObject.transform.rotation.z <= 0.35)
                    gameObject.transform.Rotate(new Vector3(0f, 0f, 0.25f));
               //Debug.Log(gameObject.transform.rotation.z);
          }
          if (!fired)
          {
               if (Input.GetKey("space"))
               {
                    Instantiate(shell, transform.position, transform.rotation);
                    fired = true;
               }
          }
	}
}
