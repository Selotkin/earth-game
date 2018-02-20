using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private Text endGameText;

	private bool gameOver = false;
	private PlayerController playerController;



	public bool GameOver {
		get {return gameOver;}
	}
	void Awake(){
		if (instance == null) {
			instance = this;
		}
		else if(instance != this){
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		playerController = player.GetComponent<PlayerController> ();
		endGameText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerController.PlayerIsDead) {
			gameOver = true;
			endGameText.enabled = true;
		}
	}



}
