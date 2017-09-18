using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
	public static GameControl instance;
	public Text distanceText;

	private int distance = 0;
	public float scrollSpeed = -1.5f;

	void Awake (){
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	void Update(){
	}
}