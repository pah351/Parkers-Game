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
	public Text TimeDisplay;
	
	public float Distance = 0;
	public float Energy = 0;
	public float Mph = 0;
	public float Dpc = 1;
	public float Eps = 0;
	public float Mover = 1;

	public int seconds = 00;
	public int minutes = 00;
	public int hours = 00;
	public int days = 00;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Time ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		DistanceDisplay.text = "Distance: " + Distance;
		EnergyDisplay.text = "Energy: " + Energy;
		MphDisplay.text = "mph: " + Mph;
		DpcDisplay.text = "Distance per click: " + Dpc;
		EpsDisplay.text = "Energy per Second: " + Eps;

		TimeDisplay.text = "Time: " + hours + ":" + minutes + ":" + seconds;
	}

	private void TimeAdd () {
		seconds += 1;
		if (seconds >= 60) {
			minutes++;
			seconds = 00;
		}
		if (minutes >= 60) {
			hours++;
			minutes = 00;
		}
		if (hours >= 24) {
			days++;
			hours = 00;
		}
	}

	IEnumerator Time()
	{
		while (true) {
			TimeAdd ();
			yield return new WaitForSeconds (1);
		}
	}
}
