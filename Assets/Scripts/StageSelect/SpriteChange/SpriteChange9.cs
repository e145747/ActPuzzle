using UnityEngine;
using System.Collections;

public class SpriteChange9 : MonoBehaviour
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

		if (9 <= maxstagenum.maxstage)
		{
			spriter.sprite = MainSprite;
		}
	}
}
