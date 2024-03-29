﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	LevelManager levelManager;
	Text text;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
		text = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time: " + levelManager.timeLeft.ToString("n2");

	}
}
