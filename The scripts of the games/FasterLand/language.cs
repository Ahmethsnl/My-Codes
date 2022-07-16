using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class language: MonoBehaviour
{
    public string tr;
    public string eng;
    public string fr;
    public string deu;
    Text text;
    void Start()
    {
        text = GetComponent <Text> ();
        DilineGore();
    }

    void DilineGore()
    {
        if (Application.systemLanguage == SystemLanguage.Turkish)
        {
            text.text = tr;
        }
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            text.text = fr;
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            text.text = deu;
        }
        else
        {
            text.text = eng;
        }
    }
}