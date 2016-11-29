using UnityEngine;
using System.Collections;

public class ItemTrigger : MonoBehaviour
{
	GameObject itemcount;
	public AudioClip ItemSe;

	void Start ()
	{
		itemcount = GameObject.Find("MainCamera");
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [15] == true)
		{
			GetComponent<AudioSource> ().PlayOneShot (ItemSe);
			FlagManager.Instance.flags [15] = false;
		}
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			ItemCounter count = itemcount.GetComponent<ItemCounter>();
			count.Count();

			FlagManager.Instance.flags [15] = true;

			gameObject.SetActive (false);
		}
	}
}
