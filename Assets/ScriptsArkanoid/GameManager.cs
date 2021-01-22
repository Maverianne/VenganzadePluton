using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance{get; set;}
	public GameObject plutonPrefab, gameOver, ganaste;
	private int vidas;
	bool win;
	bool lose;

	public Raqueta raqueta;
	private int planetas;

	void Awake(){
		Instance = this;

	}

	// Use this for initialization
	void Start () {
		lose = false;
		win = false;
		vidas = 3;
		planetas = 20;
		gameOver.SetActive(false);
		ganaste.SetActive(false);

	}
	
	public void MuerePluton()
	{
		if (vidas > 0) {
			vidas--;
		} else {
			if (win == false) {
				//Game Over
				gameOver.SetActive (true);
				lose = true;
			}

		}
	}

	public void ResetPelota()
	{
		raqueta.pelota = false;

	}

	public void MurioPlaneta(){
		planetas--;
		if (planetas == 0 && lose == false) {
			ganaste.SetActive (true);
			win = true;
		}
	}



}


