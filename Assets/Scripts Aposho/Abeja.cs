using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abeja : MonoBehaviour {
	public float speedX;
	public float speedY;


	// Use this for initialization
	void Start () {
		int rand = Random.Range (0, 3);
		if (rand == 0) {
			speedX = 0;
		}
		else if (rand == 1) {
			speedX = -speedX;
		}
		if (rand == 2){
		}
		StartCoroutine (DestroyMe());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speedX, speedY, 0f);
	}
	void OnTriggerEnter( Collider col){
		if(col.tag == "ParedI" || col.tag == "ParedD"){
			speedX = -speedX;
		}
		if (col.tag == "Nave") {
			Destroy (col.gameObject);
//			GameManager.Instance.MuereNave();
		}
		if (col.tag == "Laser") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
	}
	IEnumerator DestroyMe()
	{
		yield return new WaitForSeconds (3.0f);
		Destroy (this.gameObject);
	}
}
