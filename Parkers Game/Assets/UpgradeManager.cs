using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeManager : MonoBehaviour {

	public GameManager GM;
	private Upgrade2 upgrade2;
	public Text LevelDisplay;
	public Text CostDisplay;
	public Text EpsDisplay;

	public int Level;
	public float Cost;
	public float EnergyAdd;
	public float Time;
	public float NewCost;

	public bool Mittens;
	public bool LithiumIon;
	public bool Wings;
	public bool WindTurbines;
	public bool GlobalWarming;
	public bool ReactorCoolant;
	public bool LightningRod;
	public bool MiniSun;

	public GameObject Item;

	public int Multiplier;
	public GameObject Upgrader;

	// Use this for initialization
	void Start () {
		StartCoroutine (AutoTick());

	}
	
	// Update is called once per frame
	void Update () {

		LevelDisplay.text = "lvl: " + Level;
		CostDisplay.text = "Cost: " + Mathf.Round(NewCost);

		if (Mittens == true) {
			EpsDisplay.text = EnergyAdd*GM.Static + " Watts+";

		}
		if (LithiumIon == true) {
			EpsDisplay.text = EnergyAdd*GM.Bat + " Watts+";

		}
		if (Wings == true) {
			EpsDisplay.text = EnergyAdd*GM.Red + " Watts+";

		}
		if (WindTurbines == true) {
			EpsDisplay.text = EnergyAdd*GM.Pin + " Watts+";

		}
		if (GlobalWarming == true) {
			EpsDisplay.text = EnergyAdd*GM.Sol + " Watts+";
		}
		if (ReactorCoolant == true) {
			EpsDisplay.text = EnergyAdd*GM.Ura + " Watts+";

		}
		if (LightningRod == true) {
			EpsDisplay.text = EnergyAdd*GM.Lit + " Watts+";

		}
		if (MiniSun == true) {
			EpsDisplay.text = EnergyAdd*GM.Fus + " Watts+";

		}

		if (Level <= 0) {
			Time = 0;
		}

		if (Time >= 1) {
			GM.Energy += GM.StaticEps;
			GM.Energy += GM.BatEps;
			GM.Energy += GM.RedEps;
			GM.Energy += GM.PinEps;
			GM.Energy += GM.SolEps;
			GM.Energy += GM.UraEps;
			GM.Energy += GM.LitEps;
			GM.Energy += GM.FusEps;

			Time = 0;
		}
	}

	public void OnPurchase() {
		if(Mittens==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.StaticEps += (EnergyAdd * GM.Static);

			}
		}
		if(LithiumIon==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.BatEps += (EnergyAdd * GM.Bat);

			}
		}
		if(Wings==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.RedEps += (EnergyAdd * GM.Red);

			}
		}
		if(WindTurbines==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.PinEps += (EnergyAdd * GM.Pin);

			}
		}
		if(GlobalWarming==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.SolEps += (EnergyAdd * GM.Sol);

			}
		}
		if(ReactorCoolant==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.UraEps += (EnergyAdd * GM.Ura);

			}
		}
		if(LightningRod==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.LitEps += (EnergyAdd * GM.Lit);

			}
		}
		if(MiniSun==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));

				GM.FusEps += (EnergyAdd * GM.Fus);

			}
		}
	}


		
	private void TimeAdd() {
		Time++;
	}

	IEnumerator AutoTick() {
		while(true){
			TimeAdd ();
			yield return new WaitForSeconds(1);
		}
	}

}
