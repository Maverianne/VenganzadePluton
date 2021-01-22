using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {
	public float speedY;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0f,speedY,  0f);

	}
	void OnTriggerEnter(Collider col){
		
		if (col.tag == "DeathZone") {
			Destroy (this.gameObject);
		}
	}
}
