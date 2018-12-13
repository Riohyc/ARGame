using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 

public class Shoot : MonoBehaviour {
	float Speed = 0.5f;
	public GameObject Bullet;
	public Transform FPonit;

	public float DestroyTime = 3.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void onClick(){
		GameObject button = GameObject.Find("Canvas/Button");
		GameObject.Destroy(button);
		InvokeRepeating("Fire",0,0.5f);

	}

	public void Fire(){
		GameObject clone;
		
		clone = GameObject.Instantiate(Bullet,FPonit.position,FPonit.rotation);

		clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward*Speed); 
		
		GameObject.Destroy(clone, DestroyTime);
		
	}
}
