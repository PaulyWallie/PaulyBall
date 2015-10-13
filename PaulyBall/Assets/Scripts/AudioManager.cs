﻿using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter(Collision other){
		audioSource.Play();
	}

	void OnTriggerEnter(Collider other){
		audioSource.Play();
	}
}		
