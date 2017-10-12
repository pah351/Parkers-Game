using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade2 : MonoBehaviour {

	public UpgradeManager UM;

	public GameManager GM;
	public float NewCost;
	public GameObject Trash;
	public Text CostDisplay;
	public Text EpsMultipliedDisp;

	public bool Mittens;
	public bool LithiumIon;
	public bool Wings;
	public bool WindTurbines;
	public bool GlobalWarming;
	public bool ReactorCoolant;
	public bool LightningRod;
	public bool MiniSun;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		CostDisplay.text = "Cost: " + Mathf.Round(NewCost);
	}

	public void OnUpgrade() {
		if (Mittens == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Static = 2;
				GM.StaticEps=GM.StaticEps*2;

			}
		}
		if (LithiumIon == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Bat = 2;
				GM.BatEps = GM.BatEps * 2;
			}
		}
		if (Wings == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Red = 2;
				GM.RedEps = GM.RedEps * 2;
			}
		}
		if (WindTurbines == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Pin = 2;
				GM.PinEps = GM.PinEps * 2;
			}
		}
		if (GlobalWarming == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Sol = 2;
				GM.SolEps = GM.SolEps * 2;
			}
		}
		if (ReactorCoolant == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Ura = 2;
				GM.UraEps = GM.UraEps * 2;
			}
		}
		if (LightningRod == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Lit = 2;
				GM.LitEps = GM.LitEps * 2;
			}
		}
		if (MiniSun == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Fus = 2;
				GM.FusEps = GM.FusEps * 2;
			}
		}
		Destroy (Trash);
	}
}
