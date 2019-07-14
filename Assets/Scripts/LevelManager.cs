using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeLeft = 5f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene ().buildIndex == 1) {
			timeLeft -= Time.deltaTime;
			print ("Time remaining " + timeLeft);
		}

		if (timeLeft <= 0f) {
			LoadNextScene ();
		}

	
	}

	public void LoadNextScene(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);

	}

	public void LoadPreviousScene(){
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);

	}

}
