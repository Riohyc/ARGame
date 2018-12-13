﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack : Button {

	// Use this for initialization
	public SpaceShipController SpaceShipController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(IsPressed()){
			SpaceShipController.MoveBack();
		}
	}
}
