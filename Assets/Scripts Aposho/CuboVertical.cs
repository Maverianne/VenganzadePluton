using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboVertical : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Mueve cubo
		transform.Translate (0f, speed, 0f);
		//encuentro con la esquina
		if (transform.position.y >= 9|| transform.position.y <= -7) 
		{
			//cambia variable
			speed = -speed;
		}

	}
}
