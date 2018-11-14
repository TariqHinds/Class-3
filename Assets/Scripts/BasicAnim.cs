using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAnim : MonoBehaviour {
	Animator myAnim;
	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		myAnim.SetInteger ("state", 0);
		if (Input.GetKeyDown (KeyCode.Space)) {
			myAnim.SetInteger ("state", 1);
			Debug.Log ("Space pressed");
		}
		//myAnim.SetInteger ("state", 0);
		//When I press w key, the script runs the walk animation cycle
			if (Input.GetKeyDown (KeyCode.W)) {
				myAnim.SetInteger ("state", 2);
				Debug.Log ("w pressed");
		
			}
		if (Input.GetKeyDown (KeyCode.Q)) {
			myAnim.SetInteger ("state", 3);
			Debug.Log ("q pressed");

		}	
		if (Input.GetKeyDown (KeyCode.R)) {
			myAnim.SetInteger ("state", 3);
			Debug.Log ("r pressed");

		}	
		}
	}

