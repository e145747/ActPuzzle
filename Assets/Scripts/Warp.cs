using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	public float changeRed;
	public float changeGreen;
	public float changeBlue;
	public float changeAlpha;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (FlagManager.Instance.flags [4] == true) { // 6
			transform.position = new Vector2 (8.8f, 0.88f);
		}
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			// PlayerがWarp Blockに当たったか判定
			FlagManager.Instance.flags [5] = true;

			// Warp Block の色を変更
			changeRed = 0.0f;
			changeGreen = 1.0f;
			changeBlue = 0.0f;
			changeAlpha = 1.0f;
			this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, changeBlue, changeAlpha);
			Debug.Log ("hit player");
		}
	}
}
