using UnityEngine;
using System.Collections;

public class FreeFall : MonoBehaviour
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
			FlagManager.Instance.flags [2] = true;
		}
	}
}
