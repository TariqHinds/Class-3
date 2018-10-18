using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Transform[] loseSpot;
	public Transform winSpot;

	public float gridSize = 2f;
	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("A is down:" + Input.GetKeyDown(KeyCode.A));
	
		if (Input.GetKeyDown (KeyCode.W) && transform.position.z < 0.1589975f) {
			Debug.Log ("Player pressed w");
			transform.position += transform.forward * gridSize; 
		}
		if (Input.GetKeyDown (KeyCode.A) && transform.position.x > -7.841001f) {
		Debug.Log ("Player pressed a");
		transform.position += -transform.right * gridSize; 
		}
		if (Input.GetKeyDown (KeyCode.S) && transform.position.z > -10.841002f) {
			Debug.Log ("Player pressed s");
			transform.position += -transform.forward * gridSize; 
		}
		if (Input.GetKeyDown (KeyCode.D) && transform.position.x < 0.1589975f) {
			Debug.Log ("Player pressed d");
			transform.position += transform.right * gridSize; 
		}	
		//A code that can stop the game object from moving off of the plane: If (Player.position > Plane.position) { Player.position < Plane.position;
		//Spacebar reset of the game 
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.position = startPos; 
		}
	}
}