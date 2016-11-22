using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MesseageRead : MonoBehaviour
{
	GameObject messeage;
	GameObject item;

	int data;

	int clear;
	int playingstage;
	int maxstage;
	int score1;

	void Start ()
	{
		messeage = GameObject.Find("Canvas");
		item     = GameObject.Find ("MainCamera");
	}

	public void OnClick()
	{
		if (FlagManager.Instance.flags [10] == false)
		{
			Messeage move = messeage.GetComponent<Messeage> ();

			Invoke ("Wait", 0.3f);

			FlagManager.Instance.flags [0] = false;
			move.messeagenum = move.messeagenum + 1;

			gameObject.SetActive (false);
		}

		else   //ゲーム終了の処理
		{
			Score score = messeage.GetComponent<Score> ();
			ItemCounter itemcount = item.GetComponent<ItemCounter> ();

			clear        = PlayerPrefs.GetInt("Clear",0);
			playingstage = PlayerPrefs.GetInt("PlayingStage",0);
			maxstage     = PlayerPrefs.GetInt("MaxStage",1);
			score1       = PlayerPrefs.GetInt("Score1",0);

			//----- score save -----
			if (playingstage == 1)
			{
				if (1000 < score1)
				{
					score1 = score1 - 1000;
					FlagManager.Instance.flags [12] = true;
				}

				// ハイスコア更新
				if (score1 < score.scoredata)
				{
					int highscore = score.scoredata;

					if (itemcount.itemcount == 3)
					{
						highscore = highscore + 1000;
					}

					PlayerPrefs.SetInt ("Score1", highscore);
				}

				else
				{
					if (FlagManager.Instance.flags [12] == true)
					{
						score1 = score1 + 1000;
					}

					PlayerPrefs.SetInt ("Score1", score1);
				}
			}

			else if (playingstage == 2)
			{
			}

			//----- maxstage save -----
			if (playingstage == maxstage)   // + if (maxstage < 10)
			{
				maxstage = maxstage + 1;
				PlayerPrefs.SetInt ("MaxStage", maxstage);
			}

			clear = 1;
			PlayerPrefs.SetInt ("Clear", clear);

			PlayerPrefs.Save ();

			SceneManager.LoadScene ("StageSelect");
		}
	}

	void Wait ()
	{
		FlagManager.Instance.flags [2] = false;
	}
}
