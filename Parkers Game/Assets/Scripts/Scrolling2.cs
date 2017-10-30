using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Scrolling2 : MonoBehaviour {
	
	public GameManager GM;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
    private void Update()
    {
        rb2d.velocity = new Vector2((0 - GM.Mph), 0);
    }

    // Update is called once per frame

}