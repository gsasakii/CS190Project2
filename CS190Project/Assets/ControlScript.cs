using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

     public GameObject bomb;
     public GameObject explosion;
     public GameObject text;
     public GameObject text2;
     public GameObject flag;
     bool engineStart = false;
     bool gameOver = false;
	// Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
          if (!gameOver)
          {
               if (Input.GetKey("s"))
               {
                    engineStart = true;
                    Debug.Log("Engine Started");
               }
               if(engineStart)
                    if (Input.GetKey("d"))
                    {
                         gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3f * Time.deltaTime,
                              gameObject.transform.position.y, 0);
                    }
          }
          if (Input.GetKey("r"))
          {
               Application.LoadLevel(Application.loadedLevelName);
          }
	}

     void OnTriggerEnter2D(Collider2D coll)
     {
          Debug.Log("collision");
          if (coll.gameObject == bomb)
          {
               Debug.Log("bombed");
               gameOver = true;
               Instantiate(explosion, transform.position, Quaternion.identity);
               text.SetActive(true);
          }
          if (coll.gameObject == flag)
          {
               text2.SetActive(true);
          }
     }
}
