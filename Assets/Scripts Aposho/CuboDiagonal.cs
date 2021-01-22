using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboDiagonal : MonoBehaviour {

	public float speed;
	public float speedy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Mueve cubo
		transform.Translate (speed, speedy, 0f);
		//encuentro con la esquina
		if (transform.position.x >= 12 || transform.position.x <= -12) 
		{
			//cambia variable
			speed = -speed;
		}
		if (transform.position.y >= 9 || transform.position.y <= -7) 
		{
			//cambia variable
			speedy = -speedy;
		}
		
	}
}
