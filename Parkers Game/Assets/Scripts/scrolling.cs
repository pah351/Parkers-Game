using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrolling : MonoBehaviour
{
	float scrollSpeed = 0;
	float walk = -0.1f;
	public Button RunButton;

	private float set = 0;
	private Vector2 startPos;
	
	// Use this for initialization
	void Start ()
	{
		startPos = transform.position;
		Button btn = RunButton.GetComponent<Button>();
		btn.onClick.AddListener(Scroll);
	}
	
	// Update is called once per frame
	public void Scroll ()
	{
		
			scrollSpeed +=  walk;
			float newPos = Mathf.Repeat(Time.time * scrollSpeed, 38.4f);
			transform.position = startPos + Vector2.right * newPos;
			scrollSpeed += -walk;

		
	}
}
