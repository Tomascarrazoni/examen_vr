using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructor : MonoBehaviour
{

   
      public GameObject enemigo;
   
    void Start()
    {
       
    }
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other){
        Debug.Log ("trigger");

        
    
        
            Die(other.gameObject);
          
        
        
    }

    void Die(GameObject destruirRoca){
      
      Destroy(destruirRoca);
      
      ;

    }
}
