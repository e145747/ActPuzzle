using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeWclear : MonoBehaviour
{
	public float speed = 0.01f;
	float red, green, blue, alpha;
	int   score6;

	void Start ()
	{
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;

		score6 = PlayerPrefs.GetInt("Score6",0);
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [31] == true || FlagManager.Instance.flags [33] == true)
		{
			GetComponent<Image>().color = new Color(red, green, blue, alpha);

			FlagManager.Instance.flags [17] = true;

			if (FlagManager.Instance.flags [33] == true)
				StartCoroutine (Wait());

			if (FlagManager.Instance.flags [31] == true || FlagManager.Instance.flags [34] == true)
				alpha += speed;

			if (1 <= alpha)
			{
				StartCoroutine (flag());
			}
		}
	}

	IEnumerator flag ()
	{
		yield return new WaitForSeconds (1.0f);

		if (FlagManager.Instance.flags [31] == true)
		{
			if (score6 < 1010)
			{
				PlayerPrefs.SetInt ("Score6", 1010);
			}
			PlayerPrefs.SetInt ("StaffRoll", 0);

			Debug.Log ("False");
		}

		else if (FlagManager.Instance.flags [33] == true)
		{
			if (score6 < 1100)
			{
				PlayerPrefs.SetInt ("Score6", 1100);
			}
			PlayerPrefs.SetInt ("StaffRoll", 1);

			Debug.Log ("True");
		}

		PlayerPrefs.SetInt ("Clear", 0);
		PlayerPrefs.Save ();
		SceneManager.LoadScene ("StaffRoll");
	}

	IEnumerator Wait ()  // クリア(真)の処理を記述
	{
		yield return new WaitForSeconds (5.0f);
		FlagManager.Instance.flags [34] = true;
	}
}