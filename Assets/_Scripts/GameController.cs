﻿//Author Name: Guashti Singh
//Last Modified by: Guashti Singh
//Date last Modified: 
//Program Description: 
//Revision History: 

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	//Private Instance Variables
	private int _livesValue;
	private int _scoreValue;

	private Vector3 _playerSpawnPoint;

	//Public Access Methods
	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}	

		}
	}

	//Public Instance Variables
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;
	public GameObject player;

	// Use this for initialization
	void Start () {
		this._initialize ();
		Instantiate (this.player, this._playerSpawnPoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void _initialize (){
		this._playerSpawnPoint = new Vector3 (0f, 1.6f, -5f);
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.enabled = false;
		this.HighScoreLabel.enabled = false;
		this.RestartButton.gameObject.SetActive(false);
	}

	private void _endGame() {
		this.HighScoreLabel.text = "High Score: " + this._scoreValue;
		this.GameOverLabel.enabled = true;
		this.HighScoreLabel.enabled = true;
		this.LivesLabel.enabled = false;
		this.ScoreLabel.enabled = false;
		this.RestartButton.gameObject.SetActive(true);
	}

	//Public Methods
	public void RestartButtonClick() {
		Application.LoadLevel ("Main");
	}
}
