using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboHorizontal : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Mueve cubo
		transform.Translate (speed, 0f, 0f);
		//encuentro con la esquina
		if (transform.position.x >= 12|| transform.position.x <= -12) 
		{
			//cambia variable
			speed = -speed;
		}

		
	}
}
