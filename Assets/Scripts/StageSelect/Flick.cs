//要編集

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Flick : MonoBehaviour
{
	GameObject playermove;

	public  bool moving;

	int        clear;
	public int playingstage;
	public int maxstage;
	public int score1;
	public int score2;
	public int score3;
	public int score4;
	public int score5;

	void Start ()
	{
		//----- savedata -----
		clear        = PlayerPrefs.GetInt("Clear",0);   // bool
		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
		maxstage     = PlayerPrefs.GetInt("MaxStage",1);
		score1       = PlayerPrefs.GetInt("Score1",0);   // if(1000<=score1) score=score1-1000
		score2       = PlayerPrefs.GetInt("Score2",0);
		score3       = PlayerPrefs.GetInt("Score3",0);
		score4       = PlayerPrefs.GetInt("Score4",0);
		score5       = PlayerPrefs.GetInt("Score5",0);

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

		playermove = GameObject.Find("Player");

		Debug.Log ("clear : " + clear);
		Debug.Log ("playingstage : " + playingstage);
		Debug.Log ("maxstage : " + maxstage);
	}

	void Update ()
	{
		if (Input.GetMouseButtonUp (0))
		{
			if (moving == false)
			{
				Vector2 tapPoint = UnityEngine.Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Collider2D collider = Physics2D.OverlapPoint (tapPoint);
			
				if (collider.gameObject.tag == "SelectStage")
				{
					PlayerPrefs.SetInt ("PlayingStage", playingstage);
					PlayerPrefs.Save ();

					if (playingstage == 1)
					{
						SceneManager.LoadScene ("Stage1(Tutorial)");
					}

					if (playingstage == 2)
					{
						SceneManager.LoadScene ("Stage2(Gravity)");
					}

					if (playingstage == 3)
					{
						SceneManager.LoadScene ("Stage3(Mist)");
					}

					if (playingstage == 4)
					{
						SceneManager.LoadScene ("Stage4(Direction)");
					}

					if (playingstage == 5)
					{
						SceneManager.LoadScene ("Stage5(Gate)");
					}

					if (playingstage == 6)
					{
						SceneManager.LoadScene ("Stage6(Block)");
					}
				}
			}
		}
	}
}
