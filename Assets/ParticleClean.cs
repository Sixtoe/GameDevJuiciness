﻿using UnityEngine;
using System.Collections;

public class ParticleClean : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (!particleSystem.isPlaying)
			Destroy(gameObject);
	}
}
