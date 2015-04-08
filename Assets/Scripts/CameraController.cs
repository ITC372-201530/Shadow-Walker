﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public GameObject player;
	private Vector3 offset;
	
	void Start () 
	{
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		if (player.transform.position.y >= 1.0) {
			transform.position = player.transform.position + offset;
		}
	}
	
}