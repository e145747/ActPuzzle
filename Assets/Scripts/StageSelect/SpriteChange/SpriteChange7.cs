using UnityEngine;
using System.Collections;

public class SpriteChange7 : MonoBehaviour
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

		if (7 <= maxstagenum.maxstage)
		{
			spriter.sprite = MainSprite;
		}
	}
}
