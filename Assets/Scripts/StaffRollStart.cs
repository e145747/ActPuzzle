using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StaffRollStart : MonoBehaviour
{
	float speed = 0.005f;
	float red, green, blue, alpha;
	bool key = false;

	void Start ()
	{
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
		alpha = 1.0f;
	}

	void Update ()
	{
		if (0 <= alpha)
		{
			FlagManager.Instance.flags [19] = true;
			GetComponent<Image>().color = new Color(red, green, blue, alpha);
			alpha -= speed;
		}

		else
		{
			if (key == false)
			{
				FlagManager.Instance.flags [19] = false;
				key = true;
			}
		}
	}
}
