using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGenerate : MonoBehaviour {
	public GameObject Ship;
	public Transform ShipLocation;
	// Use this for initialization

	public float Speed = 1;
	public float Frequency = 1;
	public float DestroyTime = 3;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click(){
		GameObject button = GameObject.Find("Canvas/StartButton");
		GameObject.Destroy(button);
		InvokeRepeating("Generate", 0, Frequency);
	}
	public void Generate(){
		GameObject clone;
		
		clone = GameObject.Instantiate(Ship,ShipLocation.position,Random.rotation);

		clone.GetComponent<Rigidbody>().velocity = clone.transform.forward*Speed; 
		
		GameObject.Destroy(clone, DestroyTime);
	}
}
