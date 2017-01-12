using UnityEngine;
using System.Collections;

public class SSPlayer : MonoBehaviour
{
	Rigidbody2D act;
	GameObject cam;

	private int xx;
	public  float speed;

	int clear;
	int playingstage;

	void Start ()
	{
		act = GetComponent<Rigidbody2D>();
		cam = GameObject.Find("MainCamera");

		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
	}

	void Update ()
	{
		Flick stagenum = cam.GetComponent<Flick>();

		if (FlagManager.Instance.flags [11] == true)
		{
			transform.position = new Vector2 (playingstage * 3.7f, 3.96f);

			PlayerPrefs.SetInt ("Clear", 0);
			PlayerPrefs.Save ();

			FlagManager.Instance.flags [11] = false;
		}

		else
		{
			if (stagenum.moving == true)
			{
				if (stagenum.playingstage == 0)
				{
					transform.position = new Vector2 (-3.7f, 3.96f);
				}
				else
				{
					transform.position = new Vector2 (stagenum.playingstage * 3.7f, 3.96f);
				}

				stagenum.moving = false;
			}
		}
	}
}
