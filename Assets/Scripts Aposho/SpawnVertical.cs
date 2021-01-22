using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVertical : MonoBehaviour {

	public GameObject cuboV;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				Instantiate (cuboV, spawnPoint.position,Quaternion.identity);
			}
		
	}
}
