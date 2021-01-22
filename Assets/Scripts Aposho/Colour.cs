using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			GetComponent<MeshRenderer> ().material.color =
				Color.red;
		}
		if (Input.GetKeyDown(KeyCode.B)) {
			GetComponent<MeshRenderer> ().material.color =
				Color.blue;
		}
		if (Input.GetKeyDown(KeyCode.G)) {
			GetComponent<MeshRenderer> ().material.color =
				Color.green;
		}
	}
}
