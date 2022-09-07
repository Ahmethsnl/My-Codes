using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _SizeButton : MonoBehaviour
{
    [SerializeField] private float _test;

    bool _click;
    public int _quantity;
    public static int _quan;
    public int _plus;

    public void _size()
    {
        if(_GoldText._objectsAmount>0)
        {
        _GoldText._objectsAmount = _GoldText._objectsAmount - _quantity;
        _MagnetPoints._hoseSize = _MagnetPoints._hoseSize + _plus;
        _quantity= _quantity * 5;
        _quan = _quantity;

        _test = _MagnetPoints._hoseSize;
        Debug.Log("Yazdır");
        }

        if(_GoldText._objectsAmount<0)
        {
            _GoldText._objectsAmount = _GoldText._objectsAmount;
            // _GoldText._objectsAmount = Mathf.Abs(_GoldText._objectsAmount);
        }
    }
}
