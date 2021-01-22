using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiagonal : MonoBehaviour {
	public GameObject cuboD;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown(KeyCode.Q)) {
				Instantiate (cuboD, spawnPoint.position,Quaternion.identity);
			}
			
		
	}
}
