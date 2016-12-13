using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			// PlayerがWarp Blockに当たったか判定
			FlagManager.Instance.flags [6] = true;

			Debug.Log ("hit player");
		}
	}
}