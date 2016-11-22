using UnityEngine;
using System.Collections;

public class DebugData : MonoBehaviour
{
	void Start ()
	{
		// DeleteData (Use:TestPlay)
		PlayerPrefs.DeleteAll();
	}

	void Update ()
	{
	}
}
