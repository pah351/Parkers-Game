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
	public Text EpsDisplay;
	public Text EpcDisplay;
	public Text TimeDisplay;
	
	public float Distance = 0;
	public float Energy = 0;
	public float Mph = 0;
	public float Eps = 0;
	public float Epc = 1;
	public float Mover = 1;

	public int milliseconds = 00;
	public int seconds = 00;
	public int minutes = 00;
	public int hours = 00;
	public int days = 00;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Caller ());
	}
	
	// Update is called once per frame
	IEnumerator Caller ()
	{
		while (true) {
			DistanceDisplay.text = "Distance: " + Distance;
			EnergyDisplay.text = "Energy: " + Energy.ToString ("F0");
			MphDisplay.text = "MPH: " + Mph;
			EpsDisplay.text = "Energy per Second: " + Eps.ToString ("F1");
			EpcDisplay.text = "Energy per Click: " + Epc.ToString ("F0");
			TimeDisplay.text = "Time: " + hours + ":" + minutes + ":" + seconds;

			milliseconds += 10;

			if (milliseconds >= 1000) {
				seconds++;
				milliseconds = 0;
			}
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
			yield return new WaitForSeconds (0.01f);
		}
	}
		
}
