using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Run : MonoBehaviour
{
	public GameManager GM;
    public ParticleSystem ZapParticle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move()
	{
		GM.Energy += GM.Epc;
        ZapParticle.Play();

	}
}
