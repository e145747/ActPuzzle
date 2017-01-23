﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//要編集

public class SpriteChangeB2 : MonoBehaviour
{
	GameObject maxstage;

	void Start ()
	{
		maxstage = GameObject.Find("MainCamera");
	}

	void Update ()
	{
		Flick flickdata = maxstage.GetComponent<Flick>();

		if (flickdata.playingstage == 0 || flickdata.moving == true)
		{
			this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
		}

		else
		{
			if (flickdata.playingstage == 1)
			{
				if (1000 < flickdata.score1)
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
				}

				else
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.4f);
				}
			}

			else if (flickdata.playingstage == 2)
			{
				if (1000 < flickdata.score2)
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
				}

				else
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.4f);
				}
			}

			else if (flickdata.playingstage == 3)
			{
				if (1000 < flickdata.score3)
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
				}

				else
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.4f);
				}
			}

			else if (flickdata.playingstage == 4)
			{
				if (1000 < flickdata.score4)
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
				}

				else
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.4f);
				}
			}

			else if (flickdata.playingstage == 5)
			{
				if (1000 < flickdata.score5)
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
				}

				else
				{
					this.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.4f);
				}
			}
		}
	}
}
