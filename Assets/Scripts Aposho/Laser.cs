using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		StartCoroutine (DestroyMe());
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (0, speed, 0);
	}
	IEnumerator DestroyMe()
	{
		yield return new WaitForSeconds (3.0f);
		Destroy (this.gameObject);
	}
}
