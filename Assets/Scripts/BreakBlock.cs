using UnityEngine;
using System.Collections;

public class BreakBlock : MonoBehaviour
{
	GameObject breakcount;

	void Start ()
	{
		breakcount = GameObject.Find("MainCamera");
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			Vector2 tapPoint = UnityEngine.Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D collider = Physics2D.OverlapPoint (tapPoint);

			if (FlagManager.Instance.flags [2] == false)
            {
                if (collider.gameObject.tag == "Normal")
				{
                   GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					StartCoroutine (Breakblock(gameobject));
				}
				
				if (collider.gameObject.tag == "Grabity")
                {
					FlagManager.Instance.flags [2] = true;			
					FlagManager.Instance.flags [3] = true;

					GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					StartCoroutine (Breakblock(gameobject));

					Debug.Log ("gravity");
				}

				if (collider.gameObject.tag == "Direction")
				{
					FlagManager.Instance.flags [4] = true;

					GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					StartCoroutine (Breakblock(gameobject));

					Debug.Log ("Direction");
				}

				if (collider.gameObject.tag == "Warp1")
				{
					// Warp Block の 色が変更されてるなら
					if (FlagManager.Instance.flags [5] == true)
					{
						// Warp Blockが押されたか判断
						FlagManager.Instance.flags [6] = true;
						GameObject gameobject = collider.transform.gameObject;

						Animator anime = gameobject.GetComponent<Animator> ();
						anime.Play ("Break", 0, 0.0f);

						StartCoroutine (Breakblock(gameobject));
					}
				}

                else
                {
				}
			}
		}
	}

	IEnumerator Breakblock (GameObject gameobject)
	{
		BreakCounter count = breakcount.GetComponent<BreakCounter>();
		count.Count();

		yield return new WaitForSeconds (0.1f);
		gameobject.SetActive (false);
	}
}
