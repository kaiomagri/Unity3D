﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour {

	public float fallingTime;

	private TargetJoint2D target;

	private BoxCollider2D boxCollider;

	// Use this for initialization
	void Start ()
	{
		target = GetComponent<TargetJoint2D>();
		boxCollider = GetComponent<BoxCollider2D>();
	}
	
	private void OnCollisionEnter2D(Collision2D collision) 
	{
		if (collision.gameObject.tag == "Player")
		{
			Invoke("Falling", fallingTime);
		}
	}

	private void OnTriggerEnter2D(Collider2D collider) 
	{
		if (collider.gameObject.layer == 9)
		{
			Destroy(gameObject);
		}
	}

	void Falling()
	{
		target.enabled = false;
		boxCollider.isTrigger = true;
	}
}
