using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Magnet : MonoBehaviour
{
    public GameObject ObjeDetectorObj;
    
    void Start()
    {
        ObjeDetectorObj = GameObject.FindGameObjectWithTag("ObjectsDetector");
        ObjeDetectorObj.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Char")
        {
            StartCoroutine(ActivateObjects());
            Destroy(transform.GetChild(0).gameObject);            
        }

    }

    IEnumerator ActivateObjects()
    {
        ObjeDetectorObj.SetActive(true);
        yield return new WaitForSeconds(10F);
        ObjeDetectorObj.SetActive(false);
    }
}