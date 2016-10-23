using UnityEngine;
using System.Collections;

public class AntiGravity : MonoBehaviour {

	public float gravity = -10;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
			if (FlagManager.Instance.flags [3] == true)
			{
				gravity = gravity * -1;
				FlagManager.Instance.flags [3] = false;
			}

			Physics2D.gravity = new Vector2 (0, gravity);
		}
	}
}
