using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniSpeed : MonoBehaviour {

    public GameManager GM;

    Animator Movement;

	// Use this for initialization
	void Start () {
        Movement = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        Movement.speed = GM.Speed;
	}
}
