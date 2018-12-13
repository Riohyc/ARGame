using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveLeft(){
		transform.Translate(Vector3.left * 0.01f);
	}

	public void MoveRight(){
		transform.Translate(Vector3.right * 0.01f);
	}
	public void MoveBack(){
		transform.Translate(Vector3.back * 0.01f);
	}
	public void MoveFoward(){
		transform.Translate(Vector3.forward * 0.01f);
	}
}
