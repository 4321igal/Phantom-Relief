using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDistroy : MonoBehaviour {
    public GameObject cueb;

    // Use this for initialization
    void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {
    
        if (cueb.transform.position.z> 1)
        {
            Debug.Log("arror");

            cueb.active = false;

        }

    }
}
