using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text  timeText;
	public float countTime;

	void Start ()
	{
		countTime = 0.0f;
		timeText.text = "00:00";
	}
		
	void Update ()
	{
		if (FlagManager.Instance.flags [0] == false && FlagManager.Instance.flags [13] == false && FlagManager.Instance.flags [14] == false)
		{
			countTime += Time.deltaTime;
		}

		if (FlagManager.Instance.flags [10] == true)
		{
			gameObject.GetComponent<Text> ().enabled = true;
			timeText.text = countTime.ToString("F2");   //小数2桁にして表示
		}
	}
}
