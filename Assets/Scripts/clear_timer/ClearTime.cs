using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour
{
	GameObject timecount;

	void Start ()
	{
		timecount = GameObject.Find("MainCamera");
		gameObject.GetComponent<Text> ().enabled = false;
	}

	void Update ()
	{
		Timer time = timecount.GetComponent<Timer>();

		if (FlagManager.Instance.flags [10] == true)
		{
			GetComponent<Text>().text = "(Time " + time.countTime.ToString("F2") + ")";
			gameObject.GetComponent<Text> ().enabled = true;
		}
	}
}
