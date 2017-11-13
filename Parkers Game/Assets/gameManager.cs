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

    public int Static = 0;
    public int Bat = 0;
    public int Red = 0;
    public int Pin = 0;
    public int Sol = 0;
    public int Ura = 0;
    public int Lit = 0;
    public int Fus = 0;

    public int Staticmult = 1;
	public int Batmult = 1;
	public int Redmult = 1;
	public int Pinmult = 1;
	public int Solmult = 1;
	public int Uramult = 1;
	public int Litmult = 1;
	public int Fusmult = 1;

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

    public GameObject StaticObj;
    public GameObject BatObj;
    public GameObject RedObj;
    public GameObject PinObj;
    public GameObject SolObj;
    public GameObject UraObj;
    public GameObject LitObj;
    public GameObject FusObj;

    public GameObject stat0;
    public GameObject stat1;
    public GameObject stat2;
    public GameObject bat0;
    public GameObject bat1;
    public GameObject bat2;
    public GameObject red0;
    public GameObject red1;
    public GameObject red2;
    public GameObject pin0;
    public GameObject pin1;
    public GameObject pin2;
    public GameObject sol0;
    public GameObject sol1;
    public GameObject sol2;
    public GameObject ura0;
    public GameObject ura1;
    public GameObject ura2;
    public GameObject lit0;
    public GameObject lit1;
    public GameObject lit2;
    public GameObject fus0;
    public GameObject fus1;
    public GameObject fus2;

    public GameObject Wow;
    public GameObject Wow2;


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
		Speed = Mathf.Sqrt ((10 * Eps) / mass);
		Mph = Speed / 0.44704f;
        if (Energy >= 1) {
            Wow.SetActive(false); 
            Wow2.SetActive(false); }
        if (Energy >= 5) { StaticObj.SetActive(true); }
        if (Energy >= 15) { BatObj.SetActive(true); }
        if (Energy >= 100) { RedObj.SetActive(true); }
        if (Energy >= 1100) { PinObj.SetActive(true); }
        if (Energy >= 12000) { SolObj.SetActive(true); }
        if (Energy >= 130000) { UraObj.SetActive(true); }
        if (Energy >= 1400000) { LitObj.SetActive(true); }
        if (Energy >= 20000000) { FusObj.SetActive(true); }

        if (stat0 != null)
        {
            if (Static >= 1) { stat0.SetActive(true); }
        }
        if ( stat1 != null)
        {
            if (Static >= 1) { stat1.SetActive(true); }
        }
        if (stat2 != null)
        {
            if (Static >= 10) { stat2.SetActive(true); }
        }
        if (bat0 != null)
        {
            if (Bat >= 1) { bat0.SetActive(true); }
        }
        if (bat1 != null)
        {
            if (Bat >= 5) { bat1.SetActive(true); }
        }
        if (bat2 != null)
        {
            if (Bat >= 25) { bat2.SetActive(true); }
        }
        if (red0 != null)
        {
            if (Red >= 1) { red0.SetActive(true); }
        }
        if (red1 != null)
        {
            if (Red >= 5) { red1.SetActive(true); }
        }

        if (red2 != null)
        {
            if (Red >= 25) { red2.SetActive(true); }
        }
        if (pin0 != null)
        {
            if (Pin >= 1) { pin0.SetActive(true); }
        }
        if (pin1 != null)
        {
            if (Pin >= 5) { pin1.SetActive(true); }
        }
        if (pin2 != null)
        {
            if (Pin >= 25) { pin2.SetActive(true); }
        }
        if (sol0 != null)
        {
            if (Sol >= 1) { sol0.SetActive(true); }
        }
        if (sol1 != null)
        {
            if (Sol >= 5) { sol1.SetActive(true); }
        }
        if (sol2 != null)
        {
            if (Sol >= 25) { sol2.SetActive(true); }
        }
        if (ura0 != null)
        {
            if (Ura >= 1) { ura0.SetActive(true); }
        }
        if (ura1 != null)
        {
            if (Ura >= 5) { ura1.SetActive(true); }
        }
        if (ura2 != null)
        {
            if (Ura >= 25) { ura2.SetActive(true); }
        }
        if (lit0 != null)
        {
            if (Lit >= 1) { lit0.SetActive(true); }
        }
        if (lit1 != null)
        {
            if (Lit >= 5) { lit1.SetActive(true); }
        }
        if (lit2 != null)
        {
            if (Lit >= 25) { lit2.SetActive(true); }
        }
        if (fus1 != null)
        {
            if (Fus >= 5) { fus0.SetActive(true); }
        }
        if (fus0 != null)
        {
            if (Fus >= 1) { fus1.SetActive(true); }
        }
        if (fus2 != null)
        {
            if (Fus >= 25) { fus2.SetActive(true); }
        }


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
