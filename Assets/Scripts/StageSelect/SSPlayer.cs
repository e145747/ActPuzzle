using UnityEngine;
using System.Collections;

public class SSPlayer : MonoBehaviour
{
	Rigidbody2D act;

	private int xx;
	public  int speed;

	void Start ()
	{
		xx    = 0;
		speed = 0;

		act = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		act.velocity = new Vector2 (xx, 0).normalized * speed;
	}

	public void Right ()
	{
		xx    = 1;
		speed = 14;
	}

	public void Left ()
	{
		xx    = -1;
		speed = 14;
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag != "SelectStage")
		{
			speed = 0;
		}
	}
}
