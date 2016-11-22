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
			this.transform.localPosition = new Vector2 (0, -1.65f);
		}

		else if (0 < agravity.gravity)
		{
			this.transform.localPosition = new Vector2 (0, 1.65f);
		}
	}
}
