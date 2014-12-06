﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Vector3.Distance(transform.position, target.transform.position) > 0.9f && Vector3.Distance(transform.position, target.transform.position) < 3)
			transform.position = Vector3.Lerp (transform.position, target.transform.position, 0.05f);
	}
}