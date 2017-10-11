using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade2 : MonoBehaviour {

	public GameManager GM;
	public float NewCost;
	public GameObject Trash;
	public Text CostDisplay;
	public Text EpsMultipliedDisp;

	public int EpsMultiplied=1;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		CostDisplay.text = "Cost: " + Mathf.Round(NewCost);
		EpsMultipliedDisp.text = "EPS *: " + EpsMultiplied;

	}

	public void OnUpgrade() {

		if (GM.Energy >= NewCost) {
			GM.Energy -= NewCost;
			EpsMultiplied = 2;

		}

	}
}
