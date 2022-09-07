using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Example: MonoBehaviour
{
    public GameObject _coindeactive;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Magnet"))
        {
            _coindeactive.SetActive(false);
        }

    }
}