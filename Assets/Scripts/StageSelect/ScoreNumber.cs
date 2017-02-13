// 要編集

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
	public Text ScoreText;

	int score1pt;
	int score2pt;
	int score3pt;
	int score4pt;
	int score5pt;
	int score6pt;

	void Start ()
	{
		Flick stagenum = GetComponent<Flick>();
		
		score1pt  = stagenum.score1;
		score2pt  = stagenum.score2;
		score3pt  = stagenum.score3;
		score4pt  = stagenum.score4;
		score5pt  = stagenum.score5;
		score6pt  = stagenum.score6;  // あとで編集
	}

	void Update ()
	{
		Flick stagenum = GetComponent<Flick>();

		if (stagenum.moving == true)
		{
			ScoreText.text = "";
		}

		else
		{
			if (stagenum.playingstage == 1)
			{
				if (1000 < score1pt)
				{
					score1pt = score1pt - 1000;
				}

				ScoreText.text = "SCORE : " + score1pt.ToString ();
			}

			else if (stagenum.playingstage == 2)
			{
				if (1000 < score2pt)
				{
					score2pt = score2pt - 1000;
				}

				ScoreText.text = "SCORE : " + score2pt.ToString ();
			}

			else if (stagenum.playingstage == 3)
			{
				if (1000 < score3pt)
				{
					score3pt = score3pt - 1000;
				}

				ScoreText.text = "SCORE : " + score3pt.ToString ();
			}

			else if (stagenum.playingstage == 4)
			{
				if (1000 < score4pt)
				{
					score4pt = score4pt - 1000;
				}

				ScoreText.text = "SCORE : " + score4pt.ToString ();
			}

			else if (stagenum.playingstage == 5)
			{
				if (1000 < score5pt)
				{
					score5pt = score5pt - 1000;
				}

				ScoreText.text = "SCORE : " + score5pt.ToString ();
			}

			else if (stagenum.playingstage == 6)
			{
				if (1000 < score6pt)
				{
					score6pt = score6pt - 1000;
				}

				ScoreText.text = "SCORE : " + score6pt.ToString ();
			}

			else
			{
				ScoreText.text = "";
			}
		}
	}
}
