using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ObjectsCode : MonoBehaviour
{
    public GameObject _objectsdeactive;
    public float _objectSize;
    public int _objectspoint; 
    public static float _objectrealsize;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Magnet"))
        {
            _objectrealsize = _objectSize;
            if(_MagnetPoints._hoseSize>_objectSize)
            {
            _objectsdeactive.SetActive(false);
            _GoldText._objectsAmount = _GoldText._objectsAmount +  _objectspoint;
            }
        }
    }
}