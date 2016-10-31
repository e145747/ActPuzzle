using UnityEngine;
using System.Collections;

public class BreakCounter : MonoBehaviour
{
	public int BreakCount;

	void Start ()
	{
		BreakCount = 0;
	}

	void Update ()
	{
	}

	public void Count ()
	{
		BreakCount = BreakCount + 1;
	}
}
