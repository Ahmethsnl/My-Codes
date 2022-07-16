using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LockButton : MonoBehaviour
{
  
    void Start()
    {
        //PlayerPrefs.DeleteAll (); yazınca bütün oyun kaydını siler
        string isim = gameObject.name; 
        int levelsirasi = int.Parse(isim);
        if (PlayerPrefs.GetInt("level")+1<levelsirasi)
        {
            GetComponent<Button>().interactable = false;
        }
    }
}
