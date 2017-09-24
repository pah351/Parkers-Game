using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text DistanceDisplay;
	public Text EnergyDisplay;
	public Text MphDisplay;
	public Text DpcDisplay;
	public Text EpsDisplay;
	
	public float Distance = 0;
	public float Energy = 0;
	public float Mph = 0;
	public float Dpc = 1;
	public float Eps = 0;
	public float mover = 0;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		DistanceDisplay.text = "Distance: " + Distance;
		EnergyDisplay.text = "Energy: " + Energy;
		MphDisplay.text = "mph: " + Mph;
		DpcDisplay.text = "Distance per click: " + Dpc;
		EpsDisplay.text = "Energy per Second: " + Eps;
	}
}
