using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			FlagManager.Instance.flags [0]  = true;
			FlagManager.Instance.flags [2]  = true;
			FlagManager.Instance.flags [10] = true;
		}
	}
}
