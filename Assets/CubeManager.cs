using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    public GameObject cueb;
    public GameObject cueb1;
    public GameObject cueb2;
    public GameObject cueb3;
    public GameObject cueb4;
    public GameObject cueb5;

    private double a, b, c, d, e, f;

    


    // Use this for initialization
    void Start () {
        a = cueb.transform.position.y;
        b = cueb1.transform.position.y;
        c = cueb2.transform.position.y;
        d = cueb3.transform.position.y;
        e = cueb4.transform.position.y;
        f = cueb5.transform.position.y;

    }

    // Update is called once per frame
    void Update () {


        if (c>= 0.011 &&  c < 0.019)
        {
            Debug.Log("yes");

        }

   

    }
}
