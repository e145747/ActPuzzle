using UnityEngine;
using System.Collections;

public class AntiGravity : MonoBehaviour
{
	GameObject playeranime;
	Animator   anime;

	public float gravity = -10;

	void Start ()
	{
		playeranime = GameObject.Find("Player");
		anime = playeranime.GetComponent<Animator>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
			if (FlagManager.Instance.flags [3] == true)
			{
				gravity = gravity * -1;

				AnimeDirection ();

				FlagManager.Instance.flags [3] = false;
			}

			Physics2D.gravity = new Vector2 (0, gravity);
		}
	}

	void AnimeDirection ()
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
