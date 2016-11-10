using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
	public Text scoreText2;
	public int  itemcount;

	void Start ()
	{
		itemcount = 0;
		scoreText2.text = "Get \"?????\" : 0/3";
	}

	void Update ()
	{
		if (itemcount == 1)
		{
			scoreText2.text = "Get \"?????\" : 1/3";
		}

		if (itemcount == 2)
		{
			scoreText2.text = "Get \"?????\" : 2/3";
		}

		if (itemcount == 3)
		{
			scoreText2.text = "Get \"?????\" : 3/3";
		}
	}

	public void Count ()
	{
		itemcount = itemcount + 1;
	}
}
