using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {
	public GameObject blueprint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();
		if (Physics.Raycast (ray, out hit, 1000f)&& Input.GetMouseButton(0)) {
			Debug.Log ("You got hit!");
			if (hit.rigidbody){
				hit.rigidbody.AddForce (Random.insideUnitSphere * 9999f);
			} 
			if (Input.GetMouseButton (1)) {
				Instantiate (blueprint, hit.point, Quaternion.identity);
				Debug.Log("Multiply balls!");
			}
		}
			
	}
}
