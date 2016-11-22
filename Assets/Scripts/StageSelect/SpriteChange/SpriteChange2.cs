using UnityEngine;
using System.Collections;

public class SpriteChange2 : MonoBehaviour
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

		if (2 <= maxstagenum.maxstage)
		{
			spriter.sprite = MainSprite;
		}
	}
}
