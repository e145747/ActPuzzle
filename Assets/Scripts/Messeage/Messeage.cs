using UnityEngine;
using System.Collections;

public class Messeage : MonoBehaviour
{
	public int messeagenum;

	private int playingstage;

	void Start ()
	{
		messeagenum = 0;
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [0] == true)
		{
			if (FlagManager.Instance.flags [10] == false && messeagenum == 0)
			{
				GameObject target = this.transform.Find ("Tutorial1").gameObject;
				target.SetActive(true);
			}

			else if (FlagManager.Instance.flags [10] == false && messeagenum == 1)
			{
				GameObject target = this.transform.Find ("Tutorial2").gameObject;
				target.SetActive(true);
			}

			else if (FlagManager.Instance.flags [10] == false && messeagenum == 2)
			{
				GameObject target = this.transform.Find ("Tutorial3").gameObject;
				target.SetActive(true);
			}

			else if (FlagManager.Instance.flags [10] == false && messeagenum == 3)
			{
				GameObject target = this.transform.Find ("Tutorial4").gameObject;
				target.SetActive(true);
			}

			if (FlagManager.Instance.flags [10] == true)
			{
				GameObject target = this.transform.Find ("Clear").gameObject;
				target.SetActive(true);
			}
		}

		//ゲームオーバー
		if (FlagManager.Instance.flags [13] == true)
		{
			GameObject target = this.transform.Find ("GameOver").gameObject;
			GameObject retry = this.transform.Find ("Retry").gameObject;
			GameObject retire = this.transform.Find ("Retire").gameObject;
			target.SetActive(true);
			retry.SetActive(true);
			retire.SetActive(true);
		}

		//メニュー表示
		if (FlagManager.Instance.flags [14] == true)
		{
			GameObject target = this.transform.Find ("Menu").gameObject;
			GameObject retry = this.transform.Find ("Retry").gameObject;
			GameObject retire = this.transform.Find ("Retire").gameObject;
			GameObject stagen = this.transform.Find ("StageNumText").gameObject;
			GameObject staget = this.transform.Find ("StageTitleText").gameObject;
			target.SetActive (true);
			retry.SetActive (true);
			retire.SetActive (true);
			stagen.SetActive (true);
			staget.SetActive (true);
		}

		else if (FlagManager.Instance.flags [14] == false && FlagManager.Instance.flags [13] == false)
		{
			GameObject target = this.transform.Find ("Menu").gameObject;
			GameObject retry = this.transform.Find ("Retry").gameObject;
			GameObject retire = this.transform.Find ("Retire").gameObject;
			GameObject stagen = this.transform.Find ("StageNumText").gameObject;
			GameObject staget = this.transform.Find ("StageTitleText").gameObject;
			target.SetActive (false);
			retry.SetActive (false);
			retire.SetActive (false);
			stagen.SetActive (false);
			staget.SetActive (false);
		}
	}
}
