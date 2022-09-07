using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ObjectsMove : MonoBehaviour
{
    public _ObjectsForMagnet _objectsformagnet;
    
    void Start()
    {
        _objectsformagnet = gameObject.GetComponent<_ObjectsForMagnet>();
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _objectsformagnet._playerTransform.position,
            _objectsformagnet._movespeed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObjectsBubble")
        {
            Destroy(gameObject);
        }
    }
}