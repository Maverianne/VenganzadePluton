using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHorizontal : MonoBehaviour {
	public GameObject cuboH;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			Instantiate (cuboH, spawnPoint.position,Quaternion.identity);
		}
		
	}
}
