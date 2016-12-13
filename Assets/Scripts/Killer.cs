using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour
{
	GameObject gravitydata;

	void Start ()
	{
		gravitydata  = GameObject.Find("MainCamera");
	}

	void Update ()
	{
		AntiGravity agravity = gravitydata.GetComponent<AntiGravity>();

		if (agravity.gravity < 0) 
		{
			Invoke ("Wait1",0.15f);
		}

		else if (0 < agravity.gravity)
		{
			Invoke ("Wait2",0.15f);
		}
	}

	void Wait1 ()
	{
		this.transform.localPosition = new Vector2 (0, -1.65f);
	}

	void Wait2 ()
	{
		this.transform.localPosition = new Vector2 (0, 1.65f);
	}
}
