﻿using UnityEngine;
using System.Collections;

public class SpriteChange4 : MonoBehaviour
{
	GameObject maxstage;
	SpriteRenderer spriter;

	public Sprite MainSprite;

	void Start ()
	{
		maxstage = GameObject.Find("MainCamera");
		spriter  = gameObject.GetComponent<SpriteRenderer> ();
	}

	void Update ()
	{
		Flick maxstagenum = maxstage.GetComponent<Flick>();

		if (4 <= maxstagenum.maxstage)
		{
			spriter.sprite = MainSprite;
		}
	}
}
