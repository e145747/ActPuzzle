using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMesseage : MonoBehaviour
{
	GameObject data;

	public Text dataText;

	void Start ()
	{
		data = GameObject.Find("Canvas");
		gameObject.GetComponent<Text> ().enabled = false;
	}

	void Update ()
	{
		Score score = data.GetComponent<Score>();

		if (FlagManager.Instance.flags [10] == true)
		{
			dataText.text = "Score:" + score.scoredata.ToString();

			gameObject.GetComponent<Text> ().enabled = true;
		}
	}
}
