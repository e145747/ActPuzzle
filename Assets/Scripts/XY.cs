using UnityEngine;
using System.Collections;

public class XY : MonoBehaviour
{
	public GameObject player;

	public float x = 0f;
	public float y = 0f;

	public float xborder = 0.015f;
	public float yborder = 0.015f;

	void Start ()
	{
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 xy = UnityEngine.Camera.main.ScreenToWorldPoint (player.transform.position);

		if ((xy.x - x) < xborder * -1 || xborder < (xy.x - x))
		{
			if ((xy.y - y) < yborder * -1 || yborder < (xy.y - y))
			{
				FlagManager.Instance.flags [2] = true;
			}
		}

		float ansy = xy.y - y;

		x = xy.x;
		y = xy.y;

		Debug.Log (ansy);
	}
}
