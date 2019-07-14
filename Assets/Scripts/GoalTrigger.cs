using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider){
		ScoreTrigger trigger = GetComponentInChildren<ScoreTrigger> ();
		trigger.ExpectCollider (collider);
	}
}
