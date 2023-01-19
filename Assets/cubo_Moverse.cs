using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Moverse : MonoBehaviour
{
    public Transform Target;
    public float speed = 8.0f;

    private void FixedUpdate(){

        transform.position = Vector3.MoveTowards(transform.position,Target.position, speed * Time.deltaTime);
    }
    
}
