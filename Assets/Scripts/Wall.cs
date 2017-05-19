﻿using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    private AudioSource audio;
    
    
    // Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D()
    {
        audio.Play();
    }
}
