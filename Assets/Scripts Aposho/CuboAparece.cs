using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAparece : MonoBehaviour {

	public float speedX;
	public float speedY;

	// Use this for initialization
	void Start () {
		StartCoroutine (DestruyeCubo());

		// transform - - > GetComponent<Transform>()

		int rand = Random.Range (1, 3);

		if(rand == 1){
			speedX = 0;
		}
		if(rand == 2){
			speedY = 0;
		}

	}

	// Update is called once per frame
	void Update () {
		
			transform.Translate (speedX, speedY, 0);
	}

	IEnumerator DestruyeCubo(){
		yield return new WaitForSeconds (2.0f);

		Destroy (this.gameObject);


	}
}