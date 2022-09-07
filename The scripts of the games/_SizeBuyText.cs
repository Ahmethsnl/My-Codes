using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _SizeBuyText : MonoBehaviour
{
    Text _buytext;
    int _buyfortext;

    void Start()
    {
        _buytext = GetComponent<Text>();
        _buyfortext = _SizeButton._quan;
    }

    void Update()
    {
        _buytext.text = _buyfortext.ToString();
    }
}
