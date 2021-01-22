using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {
	public float speedX;
	public float speedY;
	bool canMove;

	// Use this for initialization
	void Start () {
		canMove = true;
		
	}
	
	// Update is called once per frame
	void Update () {
	if (canMove == true)
	{
		transform.Translate (speedX, speedY, 0f);
	}
		
	}
	void OnTriggerEnter(Collider col){
	
		if (col.tag == "RaquetaAzul") {
			GetComponent<MeshRenderer> ().material.color =
			Color.blue;
			speedX = -speedX;
		}
		if (col.tag == "RaquetaRoja") {
			GetComponent<MeshRenderer> ().material.color =
				Color.red;
			speedX = -speedX;
		}
		if (col.tag == "ParedXRojo") {

			speedY = -speedY;
		}
		if (col.tag == "ParedFuera") {
			transform.position = new Vector3 (0f, 0f, 0f);
			canMove = false;
			StartCoroutine (Restart ());
		}
	}

	IEnumerator Restart()
	{
		yield return new WaitForSeconds (1f);
		canMove = true;
	}

	}
	
