using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluton : MonoBehaviour {
	public float speedX;
	public float speedY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			transform.Translate (speedX, speedY, 0f);
	}
	void OnTriggerEnter(Collider col){

		if (col.tag == "ParedIzquierda") {
			speedX = -speedX;
		}
		if (col.tag == "ParedDerecha") {
			speedX = -speedX;
		}
		if (col.tag == "ParedArriba") {
			speedY = -speedY;
		}
		if (col.tag == "Raqueta") {
			speedY = -speedY;
		}
		if (col.tag == "DeathZone") {

			GameManager.Instance.MuerePluton ();
			StartCoroutine (DestroyMe ());
		}
		if (col.tag == "PrimerNivel") {

			Bloque bloq = col.GetComponent<Bloque> ();
			speedY = -speedY;

			if (bloq.vidas > 0) {
				bloq.vidas--;

			} else {
				Destroy (col.gameObject);
				GameManager.Instance.MurioPlaneta ();

			}
		}

	}
	
	IEnumerator DestroyMe()
	{
		yield return new WaitForSeconds (1.0f);
		GameManager.Instance.ResetPelota();
		Destroy (this.gameObject);

	}


}

