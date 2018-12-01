using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoolAgent : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent nav;
	public Transform target;
	// Use this for initialization
	void Start () {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void OnTriggerStay(Collider col){
		if (col.gameObject.CompareTag (bond)) {
			nav.destination = col.target.position;
		}
	}
}