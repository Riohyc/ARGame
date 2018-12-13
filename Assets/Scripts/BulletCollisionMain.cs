using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
        // 销毁当前游戏物体
		//Debug.Log(collision.collider.name);
		if (collision.collider.tag=="ship"){
			Debug.Log("Bang! Player ++");
			ScoreBoard.Player1Point++;
			Destroy(this.gameObject);
		}

    }
}
