using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorLR : MonoBehaviour
{
	GameObject playermove;

	Button buttonL;
	Button buttonR;

	void Start ()
	{
		playermove = GameObject.Find("MainCamera");

		buttonL = GameObject.Find ("Canvas/LeftButton").GetComponent<Button> ();
		buttonR = GameObject.Find ("Canvas/RightButton").GetComponent<Button> ();
	}

	void Update ()
	{
		Flick stagenum = playermove.GetComponent<Flick>();

		if (stagenum.playingstage == 0)
		{
			buttonL.interactable = false;
		}
		else
		{
			buttonL.interactable = true;
		}

		if (stagenum.playingstage == stagenum.maxstage)
		{
			buttonR.interactable = false;
		}
		else
		{
			buttonR.interactable = true;
		}
	}
}
