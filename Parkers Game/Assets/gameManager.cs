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

    public float scrollspeed = -1.5f;

	public float Distance = 0;
	public float Energy = 0;
	public float Mph = 0f;
	public float Epc = 1;
	public float Mover = 1;

	public float Speed;
	public float mass = 35;

	public int Static = 1;
	public int Bat = 1;
	public int Red = 1;
	public int Pin = 1;
	public int Sol = 1;
	public int Ura = 1;
	public int Lit = 1;
	public int Fus = 1;

	public float StaticEps = 0;
	public float BatEps = 0;
	public float RedEps = 0;
	public float PinEps = 0;
	public float SolEps = 0;
	public float UraEps = 0;
	public float LitEps = 0;
	public float FusEps = 0;

	public float Eps;


	public int seconds = 00;
	public int minutes = 00;
	public int hours = 00;
	public int days = 00;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Caller ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		Eps = StaticEps + BatEps + RedEps + PinEps + SolEps + UraEps + LitEps + FusEps;

		DistanceDisplay.text = "Distance: " + Distance.ToString("F1") + " Miles";
		EnergyDisplay.text = "Energy: " + Energy.ToString ("F0");
		MphDisplay.text = "MPH: " + Mph.ToString ("F2");
		EpsDisplay.text = "Energy per Second: " + Eps.ToString ("F1");
		EpcDisplay.text = "Energy per Click: " + Epc.ToString ("F0");
		TimeDisplay.text = "Time: " + hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
		Speed = Mathf.Sqrt ((15 * Eps) / mass);
		Mph = Speed / 0.44704f;
	}

	IEnumerator Caller ()
	{
		while (true) {

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
            Distance += ((Mph / 60) / 60);
            yield return new WaitForSeconds (1);
		}
	}

}
