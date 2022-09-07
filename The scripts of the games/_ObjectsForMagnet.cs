using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ObjectsForMagnet : MonoBehaviour
{
    public Transform _playerTransform;
    public float _movespeed = 70f;

    public _ObjectsMove _objectsMoveScript;
    
    void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Char").transform;
        _objectsMoveScript = gameObject.GetComponent<_ObjectsMove>();
    }


    public void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "ObjectsDetector")
        {
            _objectsMoveScript.enabled = true;
        }
    }
}