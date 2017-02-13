using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastMesseage1 : MonoBehaviour
{
	GameObject mnumber;
	public Text mText;

	int score1;
	int score2;
	int score3;
	int score4;
	int score5;

	void Start ()
	{
		mnumber = GameObject.Find("Canvas");
		gameObject.GetComponent<Text> ().enabled = false;

		score1 = PlayerPrefs.GetInt("Score1",0);
		score2 = PlayerPrefs.GetInt("Score2",0);
		score3 = PlayerPrefs.GetInt("Score3",0);
		score4 = PlayerPrefs.GetInt("Score4",0);
		score5 = PlayerPrefs.GetInt("Score5",0);

		if (1000 <= score1)
			score1 = score1 - 1000;
		if (1000 <= score2)
			score2 = score2 - 1000;
		if (1000 <= score3)
			score3 = score3 - 1000;
		if (1000 <= score4)
			score4 = score4 - 1000;
		if (1000 <= score5)
			score5 = score5 - 1000;
	}

	void Update ()
	{
		Messeage messeage = mnumber.GetComponent<Messeage>();

		if (FlagManager.Instance.flags [0] == true && FlagManager.Instance.flags [10] == false && FlagManager.Instance.flags [32] == false)
		{
			if (messeage.messeagenum == 0)
			{
				if (30 <= score1)
					mText.text = "ここは ブロックの せかいです。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 1)
			{
				if (30 <= score2)
					mText.text = "へいわな せかいに どこからか";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 2)
			{
				if (30 <= score3)
					mText.text = "その しょうたいは ウィルス でした。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 3)
			{
				if (30 <= score4)
					mText.text = "せかいに ちらばる ワクチン あつめて";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 4)
			{
				if (30 <= score5)
					mText.text = "おねがいします。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";			
			}

			else
			{
				mText.text = "";
			}

			gameObject.GetComponent<Text> ().enabled = true;
		}

		else
		{
			gameObject.GetComponent<Text> ().enabled = false;
		}
	}
}
