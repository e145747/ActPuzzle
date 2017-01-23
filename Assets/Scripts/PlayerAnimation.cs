using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour
{
	private Animator anime;

	void Start ()
	{
		anime = GetComponent<Animator>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [30] == true)
		{
			if (FlagManager.Instance.flags [1] == true)
			{
				anime.SetBool ("Attached", true);
			}
			else
			{
				anime.SetBool ("Attached", false);
			}

			FlagManager.Instance.flags [30] = false;
		}
	}
}
