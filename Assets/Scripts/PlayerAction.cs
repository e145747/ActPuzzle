using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class PlayerAction : MonoBehaviour
{
	public float x     = 1;
	public float speed = 2;

	void Start ()
	{
	}

	void Update ()
	{
		Vector2 direction = new Vector2 (x, 0).normalized;
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Block")
		{
			x = x * -1;
			Debug.Log ("attached");
		}
	}
}
