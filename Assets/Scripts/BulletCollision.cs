using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCollision : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
        // 销毁当前游戏物体
		if (this.tag == "bullet1"){
			//Debug.Log(collision.collider.name);
			if (collision.collider.name=="Plane2"){
				Debug.Log("Bang! Player1 ++");
				ScoreBoard.Player1Point++;
				Destroy(this.gameObject);
			}
		}
	   	if (this.tag == "bullet2"){
			Debug.Log(collision.collider.name);
			if (collision.collider.name=="Plane1"){
				Debug.Log("Bang! Player2 ++");
				ScoreBoard.Player2Point++;
				Destroy(this.gameObject);
			}
		}
    }
}
