using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	//Public Member Variables
	public Transform flashPoint;
	public GameObject muzzleFlash;
	public GameObject bulletImpact;

	//Private Instance Variable
	private Transform _transform;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	} //end if
	
	// Update is called once per frame
	void Update () {
		
	} //end update

	void FixedUpdate(){
		if(Input.GetButtonDown ("Fire1")) {
			Instantiate (this.muzzleFlash, flashPoint.position, Quaternion.identity);
		
			RaycastHit hit; //stores information from the Ray;

			if(Physics.Raycast(this._transform.position, this._transform.forward,out hit, 50f)){
				Instantiate (this.bulletImpact, hit.point, Quaternion.identity);
			}
		} //end if
	}
}
