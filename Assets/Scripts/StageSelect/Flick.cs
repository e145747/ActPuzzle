using UnityEngine;
using System.Collections;

public class Flick : MonoBehaviour
{
	GameObject playermove;

	private Vector2 touchStartPos;
	private Vector2 touchEndPos;

	public  bool moving;
	private int  a;
	public  int  stage;

	void Start ()
	{
		moving = false;

		a     = 0;
		stage = 0;

		playermove = GameObject.Find("Player");
	}

	void Update ()
	{
		SSPlayer move = playermove.GetComponent<SSPlayer>();

		if (move.speed == 0)
		{
			moving = false;
		}

		FlickXY ();

		if (a != 0)
		{
			if (a == 1)
			{
				// stage が表すステージにワープ
			}

			else if (a == 2) //カメラ左
			{
				move.Left();
			}

			else if (a == 3) //カメラ右
			{
				move.Right();
			}

			a = 0;
		}
	}

	void FlickXY()
	{
		if (Input.GetMouseButtonDown (0)) //Input.GetKeyDown(KeyCode.Mouse0)
		{
			touchStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}

		if (Input.GetMouseButtonUp (0))
		{
			touchEndPos   = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			
			GetDirection();
		}
	}

	void GetDirection()
	{
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;

		if (Mathf.Abs(directionY) * 3 < Mathf.Abs(directionX))
		{
			if (70 < directionX && moving == false)
			{
				if (0 < stage) // MINSTAGE
				{
					moving = true;

					stage = stage - 1;
					a = 2;
				}
			}

			else if (directionX < -70 && moving == false)
			{
				if (stage < 10) // MAXSTAGE
				{
					moving = true;

					stage = stage + 1;
					a = 3;
				}
			}
		}

		else
		{
			if (moving == false)
			{
				a = 1;
				Debug.Log ("tap");
			}
		}
	}
}
