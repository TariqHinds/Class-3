using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {
	Rigidbody obj;
	public Transform target;
	// Use this for initialization
	void Start () {
		obj = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.Normalize(target.position - transform.position);
		obj.AddForce (direction);
	}
}
