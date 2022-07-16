using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_scrpt : MonoBehaviour
{
    private float ammo_speed = 5f;

    void Start()
    {
        Destroy (gameObject, 3f);
    }
    void FixedUpdate()
    {
        transform.position += new Vector3 (ammo_speed*Time.deltaTime, 0, 0);
    }

    public void ammo_left()
    {
        ammo_speed *= -1;
    }
}
