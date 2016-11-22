using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour
{
	Rigidbody2D act;

	private int xx = 1;

	void Start ()
	{
		act = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
			if (FlagManager.Instance.flags [0] == true)
			{
				act.velocity = new Vector2 (0, 0).normalized;
			}

			else
			{
				act.velocity = new Vector2 (0, act.velocity.y).normalized * 3;
			}
		}

		else if (FlagManager.Instance.flags [2] == false)
		{
			act.velocity = new Vector2 (xx, act.velocity.y).normalized * 0.8f;
		}

		if (FlagManager.Instance.flags [4] == true)
		{
			if (FlagManager.Instance.flags [2] == false)
			{
				xx = xx * -1;
				FlagManager.Instance.flags [4] = false;
			}
		}

		// warp
		if (FlagManager.Instance.flags [6] == true)
		{
			transform.position = new Vector2 (8.8f, 0.88f);
			FlagManager.Instance.flags [6] = false;
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		Invoke ("Wait",0.03f);
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

		if (collider.gameObject.tag == "StopTrigger")
		{
			FlagManager.Instance.flags [0] = true;
			FlagManager.Instance.flags [2] = true;

			// アニメーションの停止も追加すること
		}

		if (collider.gameObject.tag == "Killer")
		{
			FlagManager.Instance.flags [2]  = true;
			FlagManager.Instance.flags [13] = true;
			gameObject.SetActive (false);
		}
	}

	void Wait ()
	{
		if (FlagManager.Instance.flags [0] == false)
		{
			FlagManager.Instance.flags [2] = false;
		}
	}
}
