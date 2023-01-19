using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject Cosa_Destruir;

    public bool stopSpawning = false;
    public float SpawnTime;
    public float SpawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);
        
    }
    public void SpawnObject(){

        
        Instantiate (Cosa_Destruir, transform.position,transform.rotation);
        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
    }

    // Update is called once per frame
   
}
