﻿using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
	public GameObject Player;

	void Start ()
	{
		Player = GameObject.Find("Player"); 
	}
		
	void Update()
	{
		transform.position = new Vector3 (Player.transform.position.x, 3.96f, -10);
	}
}