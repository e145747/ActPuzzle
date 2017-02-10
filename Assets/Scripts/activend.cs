using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activend : MonoBehaviour
{
	public Text cleartext;

	void Start ()
	{
		gameObject.GetComponent<Text> ().enabled = false;
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [35] == true)
		{
			int staffroll = PlayerPrefs.GetInt("StaffRoll",0);

			if (staffroll == 0)
				cleartext.text = "GAME CLEAR !?";
			else
				cleartext.text = "GAME CLEAR !!";

			gameObject.GetComponent<Text> ().enabled = true;
		}
	}
}
