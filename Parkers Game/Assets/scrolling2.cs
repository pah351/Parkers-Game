using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Scrolling2 : MonoBehaviour {
	
	public float speed = .3f;
	private Renderer r;
	public GameManager GM;
	// Use this for initialization
	void Start () {
		r = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Scroll () {
		Vector2 offset = new Vector2(GM.Mover * Time.time, 0);
		r.material.mainTextureOffset = offset;
	}
}