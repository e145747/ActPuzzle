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
		xx    = 0;
		speed = 0;

		act = GetComponent<Rigidbody2D>();
		cam = GameObject.Find("MainCamera");

		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [11] == true)
		{
			transform.position = new Vector2 (playingstage * 3.7f, 3.96f);

			PlayerPrefs.SetInt ("Clear", 0);
			PlayerPrefs.Save ();

			FlagManager.Instance.flags [11] = false;
		}

		act.velocity = new Vector2 (xx, 0).normalized * speed;
	}

	public void Right ()
	{
		xx    = 1;
		speed = 5;
	}

	public void Left ()
	{
		xx    = -1;
		speed = 5;
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		Flick stagenum = cam.GetComponent<Flick>();

		if (collider.gameObject.tag == "StopTrigger")
		{
			speed = 0;

			if (0 < stagenum.playingstage)
			{
				transform.position = new Vector2 (stagenum.playingstage * 3.7f, 3.96f);
			}
			else
			{
				transform.position = new Vector2 (-3.7f, 3.96f);
			}
		}
	}
}
