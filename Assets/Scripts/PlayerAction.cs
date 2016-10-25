using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class PlayerAction : MonoBehaviour
{
	Rigidbody2D act;

	public float xx    = 1;
	public float speed = 1;

	void Start ()
	{
		act = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
			act.velocity = new Vector2 (0, act.velocity.y).normalized * 3;
		}

		else if (FlagManager.Instance.flags [2] == false)
		{
			act.velocity = new Vector2 (xx, act.velocity.y).normalized;
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Stage")
		{
			Invoke ("Wait",0.03f);
		}

		else
		{
			if (FlagManager.Instance.flags [2] == true)
			{
				Invoke ("Wait",0.03f);
			}

			else
			{
				xx = xx * -1;
			}
		}

		Debug.Log ("attached");
	}

	void Wait ()
	{
		FlagManager.Instance.flags [2] = false;
	}
}
