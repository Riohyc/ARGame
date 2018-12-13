using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour {
	public Text point;
	public Slider HPStrip1;
	public Slider HPStrip2;
	public static int Player1Point = 0;
	public static int Player2Point = 0; 
	void Start () {
		HPStrip1.value = HPStrip1.maxValue;
		HPStrip2.value = HPStrip2.maxValue;
		Player1Point = 0;
		Player2Point = 0;
	}
	
	// Update is called once per frame
	void Update () {
		point.text = "Player1: " + Player1Point + "\n" + "Player2: " + Player2Point;
		HPStrip1.value = HPStrip1.maxValue - Player1Point;
		HPStrip2.value = HPStrip2.maxValue - Player2Point;

		if(HPStrip1.value == 0 ||HPStrip2.value == 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
