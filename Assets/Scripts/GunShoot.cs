using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 

public class GunShoot : MonoBehaviour {
	public float Speed = 10.0f;
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
		InvokeRepeating("Fire",0,0.5f);

	}

	public void Fire(){
		GameObject clone;
		Debug.Log(FPonit.position);
		clone = GameObject.Instantiate(Bullet,FPonit.position,Quaternion.identity);
		clone.transform.parent = GameObject.Find("ImageTarget").transform;
		clone.GetComponent<Rigidbody>().velocity = clone.transform.forward*Speed; 
		
		GameObject.Destroy(clone, DestroyTime);
		
		
	}
}
