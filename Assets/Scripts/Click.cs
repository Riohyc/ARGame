using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick()
    {
        Debug.Log("日志：中文测试");
        Debug.LogWarning("日志（警告）：中文测试");
        Debug.LogError("日志（错误）：中文测试");
    }
}
