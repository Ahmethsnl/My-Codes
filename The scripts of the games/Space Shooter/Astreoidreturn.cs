using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astreoidreturn : MonoBehaviour
{
   Rigidbody fizik;
   public int speed;
    void Start()
    {
        fizik = GetComponent<Rigidbody> ();
        fizik.angularVelocity = Random.insideUnitSphere*speed;
    }  
    
}
