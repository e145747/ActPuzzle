using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour
{
	Rigidbody2D act;
	GameObject gravitypm;
	AntiGravity gg;

	public GameObject Fo,Si,Fo2,Si2,Fo3,Si3,Fo4,Si4,Fo5,Si5; // WarpObject用

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
		Fo3 = GameObject.Find ("WarpTriggerOut3");
		Si3 = GameObject.Find ("WarpTriggerIn3");
		Fo4 = GameObject.Find ("WarpTriggerOut4");
		Si4 = GameObject.Find ("WarpTriggerIn4");
		Fo5 = GameObject.Find ("WarpTriggerOut5");
		Si5 = GameObject.Find ("WarpTriggerIn5");
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

			if (FlagManager.Instance.flags [24] == true) { // WarpTriggerOut3に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Si3.transform.position.x + 0.65f, Si3.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [24] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Si3.transform.position.x - 0.65f, Si3.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [24] = false;
				}
			}
			if (FlagManager.Instance.flags [25] == true) { // WarpTriggerIn3に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Fo3.transform.position.x + 0.65f, Fo3.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [25] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Fo3.transform.position.x - 0.65f, Fo3.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [25] = false;
				}
			}

			if (FlagManager.Instance.flags [26] == true) { // WarpTriggerOut4に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Si4.transform.position.x - 0.65f, Si4.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [26] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Si4.transform.position.x + 0.65f, Si4.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [26] = false;
				}
			}
			if (FlagManager.Instance.flags [27] == true) { // WarpTriggerIn4に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Fo4.transform.position.x - 0.65f, Fo4.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [27] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Fo4.transform.position.x + 0.65f, Fo4.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [27] = false;
				}
			}

			if (FlagManager.Instance.flags [28] == true) { // WarpTriggerOut5に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Si5.transform.position.x - 0.65f, Si5.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [28] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Si5.transform.position.x + 0.65f, Si5.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [28] = false;
				}
			}
			if (FlagManager.Instance.flags [29] == true) { // WarpTriggerIn5に触れた
				if (FlagManager.Instance.flags [1] == true) { // 左向きに進んでるなら
					transform.position = new Vector2 (Fo5.transform.position.x - 0.65f, Fo5.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [29] = false;
				} else { // 右向きに進んでるなら
					transform.position = new Vector2 (Fo5.transform.position.x + 0.65f, Fo5.transform.position.y);
					FlagManager.Instance.flags [6] = false;
					FlagManager.Instance.flags [29] = false;
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
		if (collider.gameObject.tag == "Warp_Out(3)")
		{
			FlagManager.Instance.flags [24] = true; // PlyaerがWarp(1)outに触れたらフラグ20が立つ
		}
		if (collider.gameObject.tag == "Warp_In(3)")
		{
			FlagManager.Instance.flags [25] = true; // PlayerがWarp(2)inに触れたらフラグ21が立つ
		}
		if (collider.gameObject.tag == "Warp_Out(4)")
		{
			FlagManager.Instance.flags [26] = true; // PlyaerがWarp(1)outに触れたらフラグ20が立つ
		}
		if (collider.gameObject.tag == "Warp_In(4)")
		{
			FlagManager.Instance.flags [27] = true; // PlayerがWarp(2)inに触れたらフラグ21が立つ
		}
		if (collider.gameObject.tag == "Warp_Out(5)")
		{
			FlagManager.Instance.flags [28] = true; // PlyaerがWarp(1)outに触れたらフラグ20が立つ
		}
		if (collider.gameObject.tag == "Warp_In(5)")
		{
			FlagManager.Instance.flags [29] = true; // PlayerがWarp(2)inに触れたらフラグ21が立つ
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
