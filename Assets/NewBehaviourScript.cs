using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	private Animator anime;

	void Start ()
	{
		anime = GetComponent<Animator>();
	}

	void Update ()
	{
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Block")
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
