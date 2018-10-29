using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : MonoBehaviour {
	Rigidbody obj;
	public Transform predator;
	public float forceAmt;
	// Use this for initialization
	void Start () {
		obj = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 direction = Vector3.Normalize(predator.position - transform.position);
		obj.AddForce (direction * forceAmt);
	}
	void OnCollisionEnter(Collision col){
		Debug.Log ("collision w/" + col.gameObject.name);
		if (col.transform == predator) {
			//Destroy (target);
			gameObject.SetActive(false);

		}

	}
}
