using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverInc : MonoBehaviour {

	public GameManager GM;
	// Use this for initialization
	void Start () {
		
	}
	void Update () {
	}
	// Update is called once per frame
	public void Running () {
		GM.Mover += GM.Dpc;
	}
}
