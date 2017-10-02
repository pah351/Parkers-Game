using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheating : MonoBehaviour {

	public GameManager GM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheatsOn() {
		GM.Epc += 500;
	}
}
