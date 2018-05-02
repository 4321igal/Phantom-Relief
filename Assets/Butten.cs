using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butten : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void level_1()
    {
        Application.LoadLevel("Std");
    }
    public void level_2()
    {
        Application.LoadLevel("Mirror");
    }
    public void level_3()
    {
        Application.LoadLevel("levelToStd");
    }
    public void level_4()
    {
        Application.LoadLevel("levelToMirror");
    }


    // Update is called once per frame
    void Update () {
		
	}
}
