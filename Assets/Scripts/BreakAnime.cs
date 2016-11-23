using UnityEngine;
using System.Collections;

public class BreakAnime : MonoBehaviour
{
	private Animator anime;

	void Start ()
	{
		anime = GetComponent<Animator>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [14] == true)
		{
			anime.SetBool ("anime", true);
			FlagManager.Instance.flags [14] = false;
		}
	}
}