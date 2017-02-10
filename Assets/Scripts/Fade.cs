using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
	public float speed = 0.035f;
	float red, green, blue, alpha;

	void Start ()
	{
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [6] == true)
		{
			GetComponent<Image>().color = new Color(red, green, blue, alpha);

			FlagManager.Instance.flags [17] = true;
			FlagManager.Instance.flags [19] = true;

			if (FlagManager.Instance.flags [18] == false)
			{
				alpha += speed;

				if (1 <= alpha)
				{
					StartCoroutine (flag());
				}
			}

			else
			{
				alpha -= speed;

				if (alpha <= 0)
				{
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [17] = false;
					FlagManager.Instance.flags [18] = false;
					FlagManager.Instance.flags [19] = false;
				}
			}
		}
	}

	IEnumerator flag ()
	{
		yield return new WaitForSeconds (0.01f);
		FlagManager.Instance.flags [18] = true;
	}
}