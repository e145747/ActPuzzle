using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Flick : MonoBehaviour
{
	GameObject playermove;

	private Vector2 touchStartPos;
	private Vector2 touchEndPos;

	public  bool moving;
	public  int  a;

	int        clear;
	public int playingstage;
	public int maxstage;
	public int score1;

	void Start ()
	{
		//----- savedata -----
		clear        = PlayerPrefs.GetInt("Clear",0);   // bool
		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
		maxstage     = PlayerPrefs.GetInt("MaxStage",1);
		score1       = PlayerPrefs.GetInt("Score1",0);   // if(1000<=score1) score=score1-1000

		if (clear == 0)
		{
			playingstage = 0;
			PlayerPrefs.SetInt ("PlayingStage", playingstage);
		}
		else
		{
			FlagManager.Instance.flags [11] = true;
		}

		PlayerPrefs.Save ();
		//--------------------

		moving = false;
		a  = 0;

		playermove = GameObject.Find("Player");

		Debug.Log ("clear : " + clear);
		Debug.Log ("playingstage : " + playingstage);
		Debug.Log ("maxstage : " + maxstage);
		Debug.Log ("score1 : " + score1);
	}

	void Update ()
	{
		SSPlayer move = playermove.GetComponent<SSPlayer>();

		if (move.speed == 0)
		{
			moving = false;
		}

		FlickXY ();

		if (a != 0)
		{
			if (a == 1)
			{
				Vector2 tapPoint = UnityEngine.Camera.main.ScreenToWorldPoint (touchEndPos);
				Collider2D collider = Physics2D.OverlapPoint (tapPoint);

				if (collider.gameObject.tag == "SelectStage")
				{
					PlayerPrefs.SetInt("PlayingStage", playingstage);
					PlayerPrefs.Save();

					if (playingstage == 1)
					{
						SceneManager.LoadScene ("Stage1(Tutorial)");
					}

					if (playingstage == 2)
					{
						//SceneManager.LoadScene ("SampleStage");
					}
				}
			}

			else if (a == 2) //カメラ左
			{
				move.Left();
			}

			else if (a == 3) //カメラ右
			{
				move.Right();
			}

			a = 0;
		}
	}

	void FlickXY()
	{
		if (Input.GetMouseButtonDown (0)) //Input.GetKeyDown(KeyCode.Mouse0)
		{
			touchStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}

		if (Input.GetMouseButtonUp (0))
		{
			touchEndPos   = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

			GetDirection ();
		}
	}

	void GetDirection()
	{
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;

		if (Mathf.Abs(directionY) * 3 < Mathf.Abs(directionX))
		{
			if (70 < directionX && moving == false)
			{
				if (0 < playingstage) // MINSTAGE
				{
					moving = true;

					playingstage = playingstage - 1;
					a = 2;
				}
			}

			else if (directionX < -70 && moving == false)
			{
				if (playingstage < maxstage)
				{
					moving = true;

					playingstage = playingstage + 1;
					a = 3;
				}
			}
		}

		else
		{
			if (moving == false)
			{
				a = 1;
				Debug.Log ("tap");
			}
		}
	}
}
