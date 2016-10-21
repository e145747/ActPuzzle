using UnityEngine;
using System.Collections;

public class BreakBlock : MonoBehaviour
{
	
	void Start ()
	{
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			Vector2 tapPoint = UnityEngine.Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D collider = Physics2D.OverlapPoint (tapPoint);

			if (collider.gameObject.tag == "Block")
			{
				GameObject gameobject = collider.transform.gameObject;
				gameobject.SetActive (false);

				Debug.Log ("broken block");
			}
		}
	}

}
