using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MagnetPoints : MonoBehaviour
{
    [SerializeField] private float _forcetemp ;
    
    List<Rigidbody> _rgObjects = new List<Rigidbody>();

    private Transform _magnetpoint;

    public static float _hoseSize = 10f;

    void Start()
    {
        _magnetpoint = GetComponent <Transform>();
    }

    void FixedUpdate()
    { 
        if(_hoseSize>_ObjectsCode._objectrealsize)
        {
            foreach (Rigidbody _rgobject in _rgObjects)
            {
                _rgobject.AddForce ((_magnetpoint.position - _rgobject.position) * _forcetemp * Time.fixedDeltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Objects"))
        {
            _rgObjects.Add(other.GetComponent<Rigidbody>());
        }
    }
}