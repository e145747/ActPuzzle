using UnityEngine;
using System.Collections;

public class FlagReset : MonoBehaviour
{
	void Start ()
	{
		for (int i = 0; i <= 10; i++)
		{
			FlagManager.Instance.flags [i] = false;
		}

		// Flag[11]はリセットしない

		for (int i = 12; i < 100; i++)
		{
			FlagManager.Instance.flags [i] = false;
		}
	}
}
