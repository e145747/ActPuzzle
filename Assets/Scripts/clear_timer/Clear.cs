using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
	public int playingstage;

	void Start ()
	{
		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
	}

	void Update ()
	{
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			if (playingstage <= 5)
			{
				FlagManager.Instance.flags [0]  = true;
				FlagManager.Instance.flags [2]  = true;
				FlagManager.Instance.flags [10] = true;
			}
			else
			{
				FlagManager.Instance.flags [0]  = true;
				FlagManager.Instance.flags [2]  = true;
				FlagManager.Instance.flags [31] = true;
			}
		}
	}
}
