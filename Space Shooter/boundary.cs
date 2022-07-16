using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour
{
    void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }
}
