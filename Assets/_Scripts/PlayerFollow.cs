using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {
	//Public Instance Variables
	public float speed;
	public GameController gameController;
	public Transform spawnPoint;


	//Private Instance variables
	private Transform _transform;
	private GameObject _player;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this._player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		this._transform.position = Vector3.MoveTowards(this._transform.position, this._player.transform.position, step);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {

			Transform playerTransform = other.gameObject.GetComponent<Transform> ();

			playerTransform.position = this.spawnPoint.position;
			gameController.LivesValue -= 1;
		}
	}
}
