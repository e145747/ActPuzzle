using UnityEngine;
using System.Collections;

public class playercolor : MonoBehaviour
{
	public float speed = 0.0025f;
	float red, green, blue, alpha;
	private bool alphadown;
	int aaaa;

	void Start ()
	{
		alpha = 1.0f;
		red = GetComponent<SpriteRenderer>().color.r;
		green = GetComponent<SpriteRenderer>().color.g;
		blue = GetComponent<SpriteRenderer>().color.b;

		aaaa = PlayerPrefs.GetInt("StaffRoll",0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<SpriteRenderer>().color = new Color(red, green, blue, alpha);

		if (0 <= alpha && alphadown == true)
			alpha -= speed;
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "alphadown")
		{
			if (aaaa == 1)
				alphadown = true;
		}
	}
			
}
