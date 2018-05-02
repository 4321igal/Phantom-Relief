using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var _x = Input.GetAxis("Horizontal") ;
        var _z = Input.GetAxis("Vertical");
        

        _x *= Time.deltaTime * 120f;
        _z *= Time.deltaTime * 30f;


        transform.Rotate(0, _x, 0);
        transform.Translate(0, 0, _z);
    }
}
