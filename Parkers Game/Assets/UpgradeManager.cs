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

	public int Multiplier;
	public GameObject Upgrader;

	// Use this for initialization
	void Start () {
		StartCoroutine (AutoTick());
		upgrade2 = Upgrader.GetComponent<Upgrade2>();

	}
	
	// Update is called once per frame
	void Update () {
		upgrade2 = Upgrader.GetComponent<Upgrade2>();

		LevelDisplay.text = "lvl: " + Level;
		CostDisplay.text = "Cost: " + Mathf.Round(NewCost);
		EpsDisplay.text = EnergyAdd + " Watts+";

		if (Level <= 0) {
			Time = 0;
		}

		if (Time >= 1) {
			GM.Energy += GM.Eps;
			Time = 0;
		}
	}

	public void OnPurchase() {

		if (GM.Energy >= NewCost) {
			GM.Energy -= NewCost;
			Level++;
			NewCost = Cost * (Mathf.Pow(1.15f, Level));

			GM.Eps += (EnergyAdd * upgrade2.EpsMultiplied);

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
