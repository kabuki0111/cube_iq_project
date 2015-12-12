using UnityEngine;
using System.Collections;

public class TestAppManger : MonoBehaviour {
    private float maxTime = 120.0f;
    private float minTime = 0.0f;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.maxTime -= Time.time;
        if(this.maxTime <= 0){
            Debug.Log("test");
            Application.LoadLevel("main");
        }
	}
}
