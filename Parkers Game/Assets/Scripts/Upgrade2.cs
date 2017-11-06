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

    public AudioSource source;
    public AudioClip buzz;


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
				GM.Staticmult *= 2;
				GM.StaticEps=GM.StaticEps*2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (LithiumIon == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Batmult *= 2;
				GM.BatEps = GM.BatEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (Wings == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Redmult *= 2;
				GM.RedEps = GM.RedEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (WindTurbines == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Pinmult *= 2;
				GM.PinEps = GM.PinEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (GlobalWarming == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Solmult *= 2;
				GM.SolEps = GM.SolEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (ReactorCoolant == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Uramult *= 2;
				GM.UraEps = GM.UraEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (LightningRod == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Litmult *= 2;
				GM.LitEps = GM.LitEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
		if (MiniSun == true) {
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				GM.Fusmult *= 2;
				GM.FusEps = GM.FusEps * 2;
                source.PlayOneShot(buzz);
                Destroy(Trash);

            }
        }
	}
}
