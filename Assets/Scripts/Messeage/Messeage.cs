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
			if (messeagenum == 0)
			{
				GameObject target = this.transform.Find ("Tutorial1").gameObject;
				target.SetActive(true);
			}

			if (messeagenum == 1)
			{
				GameObject target = this.transform.Find ("Tutorial2").gameObject;
				target.SetActive(true);
			}

			if (messeagenum == 2)
			{
				GameObject target = this.transform.Find ("Tutorial3").gameObject;
				target.SetActive(true);
			}

			if (messeagenum == 3)
			{
				GameObject target = this.transform.Find ("Tutorial4").gameObject;
				target.SetActive(true);
			}
		}
	}
}
