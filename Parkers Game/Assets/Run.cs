using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Run : MonoBehaviour
{
	public gameManager GM;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move()
	{
		//if (Input.GetKeyDown(KeyCode.Space))
		//{
			GM.Distance += GM.Dpc;
		//}
	}
}
