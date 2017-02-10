using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastMesseage3 : MonoBehaviour
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
	}

	void Update ()
	{
		Messeage messeage = mnumber.GetComponent<Messeage>();

		if (FlagManager.Instance.flags [0] == true && FlagManager.Instance.flags [10] == false && FlagManager.Instance.flags [32] == false)
		{
			if (messeage.messeagenum == 0)
			{
				if (90 <= score1)
					mText.text = "とても へいわな せかいです。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 1)
			{
				if (90 <= score2)
					mText.text = "まるい かたちで ころがっています。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 2)
			{
				if (90 <= score3)
					mText.text = "コアを こわしに むかっていきます。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 3)
			{
				if (90 <= score4)
					mText.text = "すぐに なおって すすんでいきます。";
				else
					mText.text = "？？？？？\n（記されている内容を読むことができません）";
			}

			else if (messeage.messeagenum == 4)
			{
				if (90 <= score5)
					mText.text = "コアと せかいが こわされるまえに ...";
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
