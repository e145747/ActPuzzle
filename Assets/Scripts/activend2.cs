using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activend2 : MonoBehaviour
{
	public Text cleartext;

	void Start ()
	{
		gameObject.GetComponent<Text> ().enabled = false;
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [35] == true)
			gameObject.GetComponent<Text> ().enabled = true;
	}
}
