using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class PlayerAction : MonoBehaviour
{
	public float xx    = 1;
	public float yy    = 1;
	public float speed = 1;

	void Start ()
	{
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
		}

		else if (FlagManager.Instance.flags [2] == false)
		{
			Vector2 direction = new Vector2 (xx, 0).normalized;
			GetComponent<Rigidbody2D> ().velocity = direction * speed;
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Stage")
		{
			FlagManager.Instance.flags [2] = false;
		}

		if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Grabity")
		{
			xx = xx * -1;
			Debug.Log ("attached");
		}
	}
}
