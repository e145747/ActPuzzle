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
		if (FlagManager.Instance.flags [10] == false)
		{
			Messeage move = messeage.GetComponent<Messeage> ();

			Invoke ("Wait", 0.3f);

			FlagManager.Instance.flags [0] = false;
			move.messeagenum = move.messeagenum + 1;

			gameObject.SetActive (false);
		}

		else
		{
			//ゲーム終了の処理
		}
	}

	void Update ()
	{
	}

	void Wait ()
	{
		FlagManager.Instance.flags [2] = false;
	}

}
