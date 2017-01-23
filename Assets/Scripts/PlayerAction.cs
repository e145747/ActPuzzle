using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour
{
	Rigidbody2D act;
	GameObject gravitypm;
	AntiGravity gg;

	public GameObject Fo,Si,Fo2,Si2; // WarpObject用

	private int xx = 1;

	void Start ()
	{
		act = GetComponent<Rigidbody2D>();
		gravitypm = GameObject.Find("MainCamera");
		gg = gravitypm.GetComponent<AntiGravity>();

		Fo = GameObject.Find ("WarpTriggerOut1");
		Si = GameObject.Find ("WarpTriggerIn1");
		Fo2 = GameObject.Find ("WarpTriggerOut2");
		Si2 = GameObject.Find ("WarpTriggerIn2");
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [2] == true)
		{
			if (FlagManager.Instance.flags [0] == true || FlagManager.Instance.flags [14] == true)
			{
				act.velocity = new Vector2 (0, 0).normalized;
			}

			else
			{
				act.velocity = new Vector2 (0, gg.gravity/100).normalized * 3;
			}
		}

		else if (FlagManager.Instance.flags [2] == false)
		{
			act.velocity = new Vector2 (xx, gg.gravity/100).normalized * 0.8f;
		}

		if (FlagManager.Instance.flags [4] == true)
		{
			if (FlagManager.Instance.flags [2] == false)
			{
				if (FlagManager.Instance.flags [1] == false)
				{
					FlagManager.Instance.flags [1] = true;
				}
				else
				{
					FlagManager.Instance.flags [1] = false;
				}

				xx = xx * -1;
				FlagManager.Instance.flags [30] = true;
			}

			FlagManager.Instance.flags [4] = false;
		}

		// warp
		if (FlagManager.Instance.flags [6] == true) // WarpにPlyerが触れた
		{
			if (FlagManager.Instance.flags [20] == true) { // WarpTriggerOut1に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Si.transform.position.x - 0.65f, Si.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [20] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Si.transform.position.x + 0.65f, Si.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [20] = false;
				}
			}
			if (FlagManager.Instance.flags [21] == true) { // WarpTriggerIn1に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Fo.transform.position.x - 0.65f, Fo.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [21] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Fo.transform.position.x + 0.65f, Fo.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [21] = false;
				}
			}

			if (FlagManager.Instance.flags [22] == true) { // WarpTriggerOut2に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Si2.transform.position.x - 0.65f, Si2.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [22] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Si2.transform.position.x + 0.65f, Si2.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [22] = false;
				}
			}
			if (FlagManager.Instance.flags [23] == true) { // WarpTriggerIn2に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Fo2.transform.position.x - 0.65f, Fo2.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [23] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Fo2.transform.position.x + 0.65f, Fo2.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [23] = false;
				}
			}
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
				if (FlagManager.Instance.flags [1] == false)
				{
					FlagManager.Instance.flags [1] = true;
				}
				else
				{
					FlagManager.Instance.flags [1] = false;
				}

				xx = xx * -1;
				FlagManager.Instance.flags [30] = true;
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
			FlagManager.Instance.flags [17]  = true;
			Invoke ("Death",1f);
		}

		if (collider.gameObject.tag == "Warp_Out(1)")
		{
			FlagManager.Instance.flags [20] = true; // PlyaerがWarp(1)outに触れたらフラグ20が立つ
		}
		if (collider.gameObject.tag == "Warp_In(1)")
		{
			FlagManager.Instance.flags [21] = true; // PlayerがWarp(2)inに触れたらフラグ21が立つ
		}
		if (collider.gameObject.tag == "Warp_Out(2)")
		{
			FlagManager.Instance.flags [22] = true; // PlyaerがWarp(1)outに触れたらフラグ20が立つ
		}
		if (collider.gameObject.tag == "Warp_In(2)")
		{
			FlagManager.Instance.flags [23] = true; // PlayerがWarp(2)inに触れたらフラグ21が立つ
		}
	}

	void Wait ()
	{
		if (FlagManager.Instance.flags [0] == false && FlagManager.Instance.flags [14] == false)
		{
			FlagManager.Instance.flags [2] = false;
		}
	}

	void Death ()
	{
		gameObject.SetActive (false);
		Invoke ("DeathMesseage",2f);
	}

	void DeathMesseage ()
	{
		FlagManager.Instance.flags [13] = true;
	}
}
