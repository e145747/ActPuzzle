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
		if (FlagManager.Instance.flags [4] == true)
		{
			if (FlagManager.Instance.flags [1] == true)
			{
				anime.SetBool ("Attached", false);
				FlagManager.Instance.flags [1] = false;
			}

			else
			{
				anime.SetBool ("Attached", true);
				FlagManager.Instance.flags [1] = true;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Wall")
		{
			if (FlagManager.Instance.flags [1] == true)
			{
				anime.SetBool ("Attached", false);
				FlagManager.Instance.flags [1] = false;
			}

			else
			{
				anime.SetBool ("Attached", true);
				FlagManager.Instance.flags [1] = true;
			}
		}
	}
}
