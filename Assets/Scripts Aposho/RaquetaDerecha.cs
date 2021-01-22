using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetaDerecha : MonoBehaviour {
	public float speedY;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate (0f, -speedY, 0f);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate (0f, speedY, 0f);
		}
	}

}
