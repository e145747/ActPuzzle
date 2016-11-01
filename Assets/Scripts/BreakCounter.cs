using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BreakCounter : MonoBehaviour
{
	public Text scoreText;
	public int  breakcount;

	void Start ()
	{
		breakcount = 0;
		scoreText.text = "Break Block : 0";
	}

	void Update ()
	{
		scoreText.text = "Break Block : " + breakcount.ToString();
	}

	public void Count ()
	{
		breakcount = breakcount + 1;
	}
}
