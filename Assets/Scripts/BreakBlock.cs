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
					gameobject.SetActive (false);
					Counter ();
				}
				
				if (collider.gameObject.tag == "Grabity")
                {
					FlagManager.Instance.flags [2] = true;			
					FlagManager.Instance.flags [3] = true;

					GameObject gameobject = collider.transform.gameObject;
					gameobject.SetActive (false);
					Counter ();

					Debug.Log ("gravity");
				}

				if (collider.gameObject.tag == "Direction")
				{
					FlagManager.Instance.flags [4] = true;

					GameObject gameobject = collider.transform.gameObject;
					gameobject.SetActive (false);
					Counter ();

					Debug.Log ("Direction");
				}

				if (collider.gameObject.tag == "Warp1") {
				// Warp Block の 色が変更されてるなら
					if (FlagManager.Instance.flags [5] == true) {
					// Warp Blockが押されたか判断
					FlagManager.Instance.flags [4] = true;
GameObject gameObject = collider.transform.gameObject;
gameObject.SetActive (false);

Debug.Log ("warp");
}
}

                else
                {
				}
			}
		}
	}

	void Counter ()
	{
		BreakCounter count = breakcount.GetComponent<BreakCounter>();
		count.Count();
	}
}
