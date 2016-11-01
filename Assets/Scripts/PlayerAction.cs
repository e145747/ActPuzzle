using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour
{
	Rigidbody2D act;

	private int xx    = 1;
	public  int speed = 1;

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

		if (FlagManager.Instance.flags [4] == true)
		{
			xx = xx * -1;
			FlagManager.Instance.flags [4] = false;
		}

		// warp
		if (FlagManager.Instance.flags [6] == true)
		{
			transform.position = new Vector2 (8.8f, 0.88f);
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		Invoke ("Wait",0.03f);

		Debug.Log ("attached");
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Wall")
		{
			if (FlagManager.Instance.flags [2] == false)
			{
				xx = xx * -1;
			}
		}
	}

	void Wait ()
	{
		FlagManager.Instance.flags [2] = false;
	}
}
