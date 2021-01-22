using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalagaShip : MonoBehaviour {
	public GameObject LaserPrefab;
	public Transform spawnPoint;
	public float speed;
	bool moveIzq;
	bool moveDer;
	// Use this for initialization
	void Start () {
		moveIzq = true;
		moveDer = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (moveIzq == true) {
				transform.Translate (-speed, 0, 0f);
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (moveDer == true) {
				transform.Translate (speed, 0, 0f);
			}
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (LaserPrefab, spawnPoint.position, Quaternion.identity);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "ParedI") {
			moveIzq = false;
	
		} else if (col.tag == "ParedD") {
			moveDer = false;
			
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "ParedI") {
			moveIzq = true;

		} else if (col.tag == "ParedD") {
			moveDer = true;

		}
	}
}
