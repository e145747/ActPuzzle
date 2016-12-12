using UnityEngine;
using System.Collections;

public class ClearMist : MonoBehaviour
{
	float fadeoutTime = 0.6f;
	float dalpha = 200f / 255f;
	private float currentTime;
	private SpriteRenderer mist;

	void Start ()
	{
		currentTime = fadeoutTime;
		mist = GetComponent<SpriteRenderer>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [16] == true)
		{
			currentTime -= Time.deltaTime;

			if (currentTime <= 0f)
			{
				gameObject.SetActive (false);
			}

			float alpha = currentTime / fadeoutTime * dalpha;

			var mcolor = mist.color;
			mcolor.a = alpha;
			mist.color = mcolor;
		}
	}
}
