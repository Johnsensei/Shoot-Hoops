using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

	Collider expectedCollider;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExpectCollider (Collider collider){

		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider){
		if (otherCollider == expectedCollider) {
			ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
			scoreKeeper.IncrementScore (1);
			AudioSource source = GetComponent<AudioSource> ();
			source.Play ();
		
		}

	}

}
