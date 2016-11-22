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
	int score7pt;
	int score8pt;
	int score9pt;
	int score10pt;

	void Start ()
	{
		Flick stagenum = GetComponent<Flick>();
		
		score1pt  = stagenum.score1;
		score2pt  = stagenum.score1;  // あとで編集
		score3pt  = stagenum.score1;
		score4pt  = stagenum.score1;
		score5pt  = stagenum.score1;
		score6pt  = stagenum.score1;
		score7pt  = stagenum.score1;
		score8pt  = stagenum.score1;
		score9pt  = stagenum.score1;
		score10pt = stagenum.score1;
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
			}

			else
			{
				ScoreText.text = "";
			}
		}
	}
}
