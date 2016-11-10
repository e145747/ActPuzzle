using UnityEngine;
using System.Collections;

public class ItemTrigger : MonoBehaviour
{
	GameObject itemcount;

	void Start ()
	{
		itemcount = GameObject.Find("MainCamera");
	}

	void Update ()
	{
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			ItemCounter count = itemcount.GetComponent<ItemCounter>();
			count.Count();

			gameObject.SetActive (false);
		}
	}
}
