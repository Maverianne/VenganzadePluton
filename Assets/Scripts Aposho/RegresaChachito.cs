using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RegresaChachito : MonoBehaviour {
	public float speedX;
	bool canMove;

	// Use this for initialization
	void Start () {
		canMove = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (canMove == true)
		{
			transform.Translate (speedX, 0f, 0f);
		}

	}
	void OnTriggerEnter(Collider col)
	{
		transform.position = new Vector3 (0f, 0f, 0f);
		canMove = false;
		StartCoroutine (ContinuaChach ());
	}

	IEnumerator ContinuaChach()
	{
		yield return new WaitForSeconds (1f);
		canMove = true;
	}
}
