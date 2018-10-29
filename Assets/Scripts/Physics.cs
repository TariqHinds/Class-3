using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

	Rigidbody sphere;
	public Vector3 direction;
	public float forceAmt;
	// Use this for initialization
	void Start () {
		sphere = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.W)) {
			sphere.AddForce (Vector3.forward * forceAmt); 
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			sphere.AddForce (Vector3.left * forceAmt); 
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			sphere.AddForce (Vector3.back * forceAmt); 
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			sphere.AddForce (Vector3.right * forceAmt); 
		}
	}
		void OnTriggerStay(Collider col){
		transform.localScale *= 1f;

		/*if (sphere >= 5f) {
			gameObject.SetActive (false);
			else 
			{
				gameObject.SetActive (true);
			}
		 
		}
*/
}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("playable")){

		}
	}


