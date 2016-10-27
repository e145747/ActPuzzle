using UnityEngine;
using System.Collections;

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
