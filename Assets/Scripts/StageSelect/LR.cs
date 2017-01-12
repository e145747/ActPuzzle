using UnityEngine;
using System.Collections;

public class LR : MonoBehaviour
{
	GameObject playermove;

	void Start ()
	{
		playermove = GameObject.Find("MainCamera");
	}

	void Update ()
	{
	}

	public void OnClickRight()
	{
		Flick stagenum = playermove.GetComponent<Flick>();

		if (stagenum.moving == false && stagenum.playingstage < stagenum.maxstage)
		{
			stagenum.playingstage = stagenum.playingstage + 1;
			stagenum.moving = true;
		}
	}

	public void OnClickLeft()
	{
		Flick stagenum = playermove.GetComponent<Flick>();

		if (stagenum.moving == false && 0 < stagenum.playingstage)
		{
			stagenum.playingstage = stagenum.playingstage - 1;
			stagenum.moving = true;
		}
	}
}
