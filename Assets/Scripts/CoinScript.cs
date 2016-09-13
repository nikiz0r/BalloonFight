﻿using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

    private MainScript mainScript;

	// Use this for initialization
	void Start () {
        mainScript = (MainScript)FindObjectOfType(typeof(MainScript));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        mainScript.score++;
    }
}
