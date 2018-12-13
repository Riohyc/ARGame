using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find("ImageTarget/gun").transform.position = new Vector3(-0.5f, -0.11f, -3.035f);
	}
}
