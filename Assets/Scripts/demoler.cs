using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class demoler : MonoBehaviour
{
    public GameObject diana;
    [SerializeField]
    float RangeDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float distance = Vector3.Distance(transform.position,diana.transform.position);

        if (distance < RangeDestroy){

        print("le has dado");
        Destroy(diana);
    }
   
}
}
