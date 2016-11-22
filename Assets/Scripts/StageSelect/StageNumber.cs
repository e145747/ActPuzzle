using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageNumber : MonoBehaviour
{
	public Text StageText;

	void Start ()
	{
	}

	void Update ()
	{
		Flick stagenum = GetComponent<Flick>();

		if (stagenum.moving == true)
		{
			StageText.text = "";
		}

		else
		{
			if (stagenum.playingstage != 0)
			{
				StageText.text = "STAGE : " + stagenum.playingstage.ToString ();
			}

			else
			{
				StageText.text = "";
			}
		}
	}
}
