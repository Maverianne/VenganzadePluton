using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour {
	
	public GameObject PlutonPrefab;
	public Transform spawnPoint;
	public float speedX;
	public bool pelota;
	public GameObject InsertCoin;
	bool moveIzq;
	bool moveDer;
	bool invertir;
	bool start;


	// Use this for initialization
	void Start () {
		pelota = false;
		moveIzq = true;
		moveDer = true;
		invertir = false;
		start = false;
	
		InsertCoin.SetActive (true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (start == true) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				if (moveIzq == true) {
					transform.Translate (-speedX, 0f, 0f);
				}
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (moveDer == true) {
					transform.Translate (speedX, 0f, 0f);
				}
			}
		}
			if (pelota == false && start == true) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					Instantiate (PlutonPrefab, spawnPoint.position, Quaternion.identity);
					pelota = true;
				}
			}
		

		if (Input.GetKey (KeyCode.Space) || Input.GetKey(KeyCode.Return)) {
			InsertCoin.SetActive (false);
			start = true;
		}
		
			
	}

	void OnTriggerEnter(Collider col){


		if (invertir == false) {
			if (col.tag == "ParedIzquierda") {
			
				moveIzq = false;

			}

			if (col.tag == "ParedDerecha") {
				moveDer = false;
		
			}
		}

		if (invertir == true) {
			if (col.tag == "ParedIzquierda") {

				moveDer = false;

			}

			if (col.tag == "ParedDerecha") {
				
				moveIzq = false;

			}
		}
			
			if (col.tag == "Up") {
				StartCoroutine (Fast ());
				Destroy (col.gameObject);
			}
			if (col.tag == "Multiply") {

				StartCoroutine (Invertir ());
				Destroy (col.gameObject);
			}
			if (col.tag == "Down") {

				StartCoroutine (Slow ());
				Destroy (col.gameObject);
			}
	}

	void OnTriggerExit(Collider col)
	{
		if (invertir == false) {
			if (col.tag == "ParedIzquierda") {

				moveIzq = true;

			}

			if (col.tag == "ParedDerecha") {
				moveDer = true;

			}
		}
		if (invertir == true) {
			if (col.tag == "ParedIzquierda") {
				moveDer = true;
			}

			if (col.tag == "ParedDerecha") {
				
				moveIzq = true;
			}
		}
	}
	IEnumerator Fast()
	{
		speedX = .3f;
		yield return new WaitForSeconds (3f);
		speedX = .2F;
	
	}
		IEnumerator Invertir(){
			invertir = true;
			speedX = -speedX;
			yield return new WaitForSeconds (3f);
			invertir = false;
			speedX = -speedX;
	

	}

	IEnumerator Slow()
	{
		speedX = .05f;
		yield return new WaitForSeconds (3f);
		speedX = .2F;

	}
}
