using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliScript : MonoBehaviour {
     public GameObject tank;
     public GameObject bomb;
     public GameObject shell;
     public GameObject explosion;
     bool right = false;
     bool up = false;
     bool bombDropped = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
          if (tank.transform.position.x >= gameObject.transform.position.x - 1)
          {
               if(!bombDropped){
                    bomb.transform.position = gameObject.transform.position;
                    bombDropped = true;
               }
          }
          if (right)
          {
               if (gameObject.transform.position.x < 45f)
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2f * Time.deltaTime, gameObject.transform.position.y, 0f);
               else
                    right = false;
          }
          else
          {
               if (gameObject.transform.position.x > 30f)
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 2f * Time.deltaTime, gameObject.transform.position.y, 0f);
               else
                    right = true;
          }
          if (up)
          {
               if (gameObject.transform.position.y < 7.25f)
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f * Time.deltaTime, 0f);
               else
                    up = false;
          }
          else
          {
               if (gameObject.transform.position.y > 6.75f)
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1f * Time.deltaTime, 0f);
               else
                    up = true;
          }
	}

     void OnTriggerEnter2D(Collider2D coll)
     {
          Debug.Log("boom");
          if (coll.gameObject.tag == "Shell")
          {
               Instantiate(explosion, transform.position, Quaternion.identity);
               Destroy(gameObject);
          }
     }

}
