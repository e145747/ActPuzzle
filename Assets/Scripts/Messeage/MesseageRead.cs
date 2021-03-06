﻿//要編集

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MesseageRead : MonoBehaviour
{
	public AudioClip MenuSE;
	public AudioClip MenuSE2;

	GameObject messeage;
	GameObject item;

	int data;

	int clear;
	int playingstage;
	int maxstage;
	int score1;
	int score2;
	int score3;
	int score4;
	int score5;

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

			if (FlagManager.Instance.flags [35] == true)
				SceneManager.LoadScene ("StageSelect");
		}

		else   //ゲーム終了の処理
		{
			Score score = messeage.GetComponent<Score> ();
			ItemCounter itemcount = item.GetComponent<ItemCounter> ();

			clear        = PlayerPrefs.GetInt("Clear",0);
			playingstage = PlayerPrefs.GetInt("PlayingStage",0);
			maxstage     = PlayerPrefs.GetInt("MaxStage",1);
			score1       = PlayerPrefs.GetInt("Score1",0);
			score2       = PlayerPrefs.GetInt("Score2",0);
			score3       = PlayerPrefs.GetInt("Score3",0);
			score4       = PlayerPrefs.GetInt("Score4",0);
			score5       = PlayerPrefs.GetInt("Score5",0);

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
				if (1000 < score2)
				{
					score2 = score2 - 1000;
					FlagManager.Instance.flags [12] = true;
				}

				// ハイスコア更新
				if (score2 < score.scoredata)
				{
					int highscore = score.scoredata;

					if (itemcount.itemcount == 3)
					{
						highscore = highscore + 1000;
					}

					PlayerPrefs.SetInt ("Score2", highscore);
				}

				else
				{
					if (FlagManager.Instance.flags [12] == true)
					{
						score2 = score2 + 1000;
					}

					PlayerPrefs.SetInt ("Score2", score2);
				}
			}

			else if (playingstage == 3)
			{
				if (1000 < score3)
				{
					score3 = score3 - 1000;
					FlagManager.Instance.flags [12] = true;
				}

				// ハイスコア更新
				if (score3 < score.scoredata)
				{
					int highscore = score.scoredata;

					if (itemcount.itemcount == 3)
					{
						highscore = highscore + 1000;
					}

					PlayerPrefs.SetInt ("Score3", highscore);
				}

				else
				{
					if (FlagManager.Instance.flags [12] == true)
					{
						score3 = score3 + 1000;
					}

					PlayerPrefs.SetInt ("Score3", score3);
				}
			}

			else if (playingstage == 4)
			{
				if (1000 < score4)
				{
					score4 = score4 - 1000;
					FlagManager.Instance.flags [12] = true;
				}

				// ハイスコア更新
				if (score4 < score.scoredata)
				{
					int highscore = score.scoredata;

					if (itemcount.itemcount == 3)
					{
						highscore = highscore + 1000;
					}

					PlayerPrefs.SetInt ("Score4", highscore);
				}

				else
				{
					if (FlagManager.Instance.flags [12] == true)
					{
						score4 = score4 + 1000;
					}

					PlayerPrefs.SetInt ("Score4", score4);
				}
			}

			else if (playingstage == 5)
			{
				if (1000 < score5)
				{
					score5 = score5 - 1000;
					FlagManager.Instance.flags [12] = true;
				}

				// ハイスコア更新
				if (score5 < score.scoredata)
				{
					int highscore = score.scoredata;

					if (itemcount.itemcount == 3)
					{
						highscore = highscore + 1000;
					}

					PlayerPrefs.SetInt ("Score5", highscore);
				}

				else
				{
					if (FlagManager.Instance.flags [12] == true)
					{
						score5 = score5 + 1000;
					}

					PlayerPrefs.SetInt ("Score5", score5);
				}
			}


			//----- maxstage save -----
			if (playingstage == maxstage && playingstage <= 5)   // + if (maxstage < 10)
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

	public void OnClickRetry()
	{
		playingstage = PlayerPrefs.GetInt("PlayingStage",0);

		if (playingstage == 1)
		{
			SceneManager.LoadScene ("Stage1(Tutorial)");
		}

		else if (playingstage == 2)
		{
			SceneManager.LoadScene ("Stage2(Gravity)");
		}

		else if (playingstage == 3)
		{
			SceneManager.LoadScene ("Stage3(Mist)");
		}

		else if (playingstage == 4)
		{
			SceneManager.LoadScene ("Stage4(Direction)");
		}

		else if (playingstage == 5)
		{
			SceneManager.LoadScene ("Stage5(Gate)");
		}

		else if (playingstage == 6)
		{
			SceneManager.LoadScene ("Stage6(Block)");
		}
	}

	public void OnClickRetire()
	{
		clear = 1;
		PlayerPrefs.SetInt ("Clear", clear);

		SceneManager.LoadScene ("StageSelect");
	}

	public void OnClickMenu()
	{
		if (FlagManager.Instance.flags [0] == false && FlagManager.Instance.flags [10] == false && FlagManager.Instance.flags [13] == false && FlagManager.Instance.flags [32] == false)
		{
			if (FlagManager.Instance.flags [14] == false)
			{
				GetComponent<AudioSource> ().PlayOneShot (MenuSE);
				FlagManager.Instance.flags [2] = true;
				FlagManager.Instance.flags [14] = true;
			}

			else if (FlagManager.Instance.flags [14] == true)
			{
				GetComponent<AudioSource> ().PlayOneShot (MenuSE2);
				FlagManager.Instance.flags [2] = false;
				FlagManager.Instance.flags [14] = false;
			}
		}
	}

	public void OnClickContinue()  // クリア(偽)の処理を記述
	{
		FlagManager.Instance.flags [31] = true;
	}

	void Wait ()
	{
		FlagManager.Instance.flags [2] = false;
	}
}
