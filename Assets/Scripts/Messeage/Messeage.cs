using UnityEngine;
using System.Collections;

public class Messeage : MonoBehaviour
{
	public int messeagenum;
	public int aaaa = 0;

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
			}
		}
	}
}
