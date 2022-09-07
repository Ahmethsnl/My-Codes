using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GoldText : MonoBehaviour
{
    Text _goldtext;

    public static int _objectsAmount ;

    void Start()
    {
        _goldtext = GetComponent<Text>();
    }

    void Update()
    {
        _goldtext.text = _objectsAmount.ToString();
    }
}
