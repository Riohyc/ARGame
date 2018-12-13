using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShoot : Button {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject LeftGun;
	public GameObject RightGun;
	
	// Update is called once per frame
	void Update () {
		if(IsPressed()){
			LeftGun.GetComponent<GunShoot>().Fire();
			RightGun.GetComponent<GunShoot>().Fire();
		}
	}
}
