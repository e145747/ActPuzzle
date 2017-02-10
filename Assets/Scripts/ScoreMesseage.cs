using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMesseage : MonoBehaviour
{
	GameObject data;

	public Text dataText;

	int score1, score2, score3, score4, score5, score6;

	void Start ()
	{
		data = GameObject.Find("Canvas");
		gameObject.GetComponent<Text> ().enabled = false;

		score1 = PlayerPrefs.GetInt("Score1",0);
		score2 = PlayerPrefs.GetInt("Score2",0);
		score3 = PlayerPrefs.GetInt("Score3",0);
		score4 = PlayerPrefs.GetInt("Score4",0);
		score5 = PlayerPrefs.GetInt("Score5",0);
		score6 = PlayerPrefs.GetInt("Score6",0);

		score1 = score1 + score2 + score3 + score4 + score5 + score6;
	}

	void Update ()
	{
		Score score = data.GetComponent<Score>();

		if (FlagManager.Instance.flags [10] == true)
		{
			dataText.text = "Score:" + score.scoredata.ToString();

			gameObject.GetComponent<Text> ().enabled = true;
		}

		if (FlagManager.Instance.flags [35] == true)
		{
			while (1000 <= score1)
				score1 = score1 - 1000;

			dataText.text = "Total Score\n" + score1.ToString() + "/600";

			gameObject.GetComponent<Text> ().enabled = true;
		}
	}
}
