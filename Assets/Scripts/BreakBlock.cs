 using UnityEngine;
using System.Collections;

public class BreakBlock : MonoBehaviour
{
	public AudioClip BreakSE;
	public AudioClip MistSE;

	GameObject breakcount;
	Animator animet;

	void Start ()
	{
		breakcount = GameObject.Find("MainCamera");
		animet = GetComponent<Animator>();
	}

	void Update ()
	{
		if (Input.GetMouseButtonUp (0))
		{
			Vector2 tapPoint = UnityEngine.Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D collider = Physics2D.OverlapPoint (tapPoint);

			if (FlagManager.Instance.flags [2] == false && FlagManager.Instance.flags [14] == false && FlagManager.Instance.flags [17] == false)
            {
                if (collider.gameObject.tag == "Normal")
				{
                   GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					GetComponent<AudioSource> ().PlayOneShot (BreakSE);

					StartCoroutine (Breakblock(gameobject));
				}
				
				if (collider.gameObject.tag == "Grabity")
                {
					FlagManager.Instance.flags [2] = true;			
					FlagManager.Instance.flags [3] = true;

					GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					GetComponent<AudioSource> ().PlayOneShot (BreakSE);

					StartCoroutine (Breakblock(gameobject));

					Debug.Log ("gravity");
				}

				if (collider.gameObject.tag == "Direction")
				{
					FlagManager.Instance.flags [4] = true;

					GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					GetComponent<AudioSource> ().PlayOneShot (BreakSE);

					StartCoroutine (Breakblock(gameobject));

					if (FlagManager.Instance.flags [1] == false)
					{
						animet.SetBool ("Attached", true);
						FlagManager.Instance.flags [1] = true;
					}
					else
					{
						animet.SetBool ("Attached", false);
						FlagManager.Instance.flags [1] = false;
					}

					Debug.Log ("Direction");
				}

				if (collider.gameObject.tag == "BBarrier")
				{
					FlagManager.Instance.flags [16] = true;

					GameObject gameobject = collider.transform.gameObject;

					Animator anime = gameobject.GetComponent<Animator> ();
					anime.Play ("Break", 0, 0.0f);

					GetComponent<AudioSource> ().PlayOneShot (BreakSE);
					GetComponent<AudioSource> ().PlayOneShot (MistSE);

					for (int i = 0; i < 5; i++)
					{
						StartCoroutine (Breakblock(gameobject));
					}

					Debug.Log ("BBarrier");
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
