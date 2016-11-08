using UnityEngine;
using System.Collections;

public class MesseageRead : MonoBehaviour
{
	GameObject messeage;

	void Start ()
	{
		messeage = GameObject.Find("Canvas");
	}

	public void OnClick()
	{
		Messeage move = messeage.GetComponent<Messeage>();

		//Messeage messeage = GetComponent<Messeage>();

		Invoke ("Wait",0.3f);

		move.messeagenum = move.messeagenum + 1;
		gameObject.SetActive(false);
	}
		

	void Update ()
	{
	}

	void Wait ()
	{
		FlagManager.Instance.flags [0] = false;
		FlagManager.Instance.flags [2] = false;
	}

}
