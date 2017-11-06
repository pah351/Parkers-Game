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
    public Text NumDisplay;

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

    public AudioClip buzz;
    public AudioSource source;

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
			EpsDisplay.text = EnergyAdd*GM.Staticmult + " Watts+";
            NumDisplay.text = GM.Static.ToString();

		}
		if (LithiumIon == true) {
			EpsDisplay.text = EnergyAdd*GM.Batmult + " Watts+";
            NumDisplay.text = GM.Bat.ToString();

        }
        if (Wings == true) {
			EpsDisplay.text = EnergyAdd*GM.Redmult + " Watts+";
            NumDisplay.text = GM.Red.ToString();

        }
        if (WindTurbines == true) {
			EpsDisplay.text = EnergyAdd*GM.Pinmult + " Watts+";
            NumDisplay.text = GM.Pin.ToString();

        }
        if (GlobalWarming == true) {
			EpsDisplay.text = EnergyAdd*GM.Solmult + " Watts+";
            NumDisplay.text = GM.Sol.ToString();

        }
        if (ReactorCoolant == true) {
			EpsDisplay.text = EnergyAdd*GM.Uramult + " Watts+";
            NumDisplay.text = GM.Ura.ToString();


        }
        if (LightningRod == true) {
			EpsDisplay.text = EnergyAdd*GM.Litmult + " Watts+";
            NumDisplay.text = GM.Lit.ToString();

        }
        if (MiniSun == true) {
			EpsDisplay.text = EnergyAdd*GM.Fusmult + " Watts+";
            NumDisplay.text = GM.Fus.ToString();

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
                GM.Static++;
				GM.StaticEps += (EnergyAdd * GM.Staticmult);
                source.PlayOneShot(buzz);

			}
		}
		if(LithiumIon==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Bat++;

                GM.BatEps += (EnergyAdd * GM.Batmult);
                source.PlayOneShot(buzz);

            }
        }
		if(Wings==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Red++;

                GM.RedEps += (EnergyAdd * GM.Redmult);
                source.PlayOneShot(buzz);

            }
        }
		if(WindTurbines==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Pin++;

                GM.PinEps += (EnergyAdd * GM.Pinmult);
                source.PlayOneShot(buzz);

            }
        }
		if(GlobalWarming==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Sol++;

                GM.SolEps += (EnergyAdd * GM.Solmult);
                source.PlayOneShot(buzz);

            }
        }
		if(ReactorCoolant==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Ura++;

                GM.UraEps += (EnergyAdd * GM.Uramult);
                source.PlayOneShot(buzz);

            }
        }
		if(LightningRod==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Lit++;

                GM.LitEps += (EnergyAdd * GM.Litmult);
                source.PlayOneShot(buzz);

            }
        }
		if(MiniSun==true){
			if (GM.Energy >= NewCost) {
				GM.Energy -= NewCost;
				Level++;
				NewCost = Cost * (Mathf.Pow(1.15f, Level));
                GM.Fus++;

                GM.FusEps += (EnergyAdd * GM.Fusmult);
                source.PlayOneShot(buzz);

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
