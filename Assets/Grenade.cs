using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

 




    // Update is called once per frame

    public GameObject enemyPrefab;
    public int numberofEnemies;

    void Start()
    {
        for (int i = 0; i < numberofEnemies; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(0.0f, 8.0f), 0.0f, Random.Range(-8.0f, 8.0f));
            Quaternion spawnRotatin = Quaternion.Euler(0.0f, Random.Range(0.0f, 180.0f), 0);
            GameObject enemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, spawnRotatin);


        }
    }

    public void StdLoop()
    {
        
        Application.LoadLevel("levelToStd");
    }
    public void MirrorLoop()
    {
        Application.LoadLevel("levelToMirror");
    }

    

    public void DidroyAwka()
    {
        Destroy(this.gameObject);
    }

    public void StartDesroy()
    {
        
        Invoke("DidroyAwka", 5);

    }






}
