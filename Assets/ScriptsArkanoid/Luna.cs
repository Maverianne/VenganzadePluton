using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luna : MonoBehaviour {
	public GameObject MultiplyPrefab, DownPrefab, UpPrefab;
	public Transform spawnPoint;


	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider col){
		
		if (col.tag == "Pluton") {
			int rand = Random.Range (1, 11);

			if (rand == 1) {
				Instantiate (UpPrefab, spawnPoint.position, Quaternion.identity);
			}
			if (rand == 2) {
				Instantiate (DownPrefab, spawnPoint.position, Quaternion.identity);
			}
			if (rand == 3) {

				Instantiate (MultiplyPrefab, spawnPoint.position, Quaternion.identity);
			}

			if (rand == 4) {
				
			}
			if (rand == 5) {

			}
			if (rand == 6) {

			}
			if (rand == 7) {

			}
			if (rand == 8) {

			}
			if (rand == 9) {

			}
			if (rand == 10) {

			}

		}
	
	}
}



