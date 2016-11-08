using UnityEngine;
using System.Collections;

public class Messeage : MonoBehaviour
{
	private int messeagenum;
	public int aaaa = 0;

	private int playingstage;

	void Start ()
	{
		messeagenum = 0;

		// あとでうごかす
		PlayerPrefs.SetInt("PlayingStage", aaaa);
		PlayerPrefs.Save();

		playingstage = PlayerPrefs.GetInt("PlayingStage");
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [0] == true)
		{
			if (messeagenum == 0)
			{
				if (playingstage == 0)
				{
					GameObject target = GameObject.Find("Tutorial1"); 
				}
			}

			if (messeagenum == 1) {
			}

			messeagenum = messeagenum + 1;

			//FlagManager.Instance.flags [0] = false; ボタン押したら解除
		}
	}
}
