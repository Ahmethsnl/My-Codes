using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyAstreoids : MonoBehaviour
{
    public GameObject patlama; 
    public GameObject playerpatlama;
    GameObject GameControl;
    GameControl control;


    void Start()
    {
      GameControl=GameObject.FindGameObjectWithTag("GameControl");
      control=GameControl.GetComponent<GameControl>();
    }

  void OnTriggerEnter(Collider col)
    {
        if(col.tag!="sinir")
        {
        Destroy (col.gameObject);
        Destroy (gameObject);
        Instantiate(patlama,transform.position,transform.rotation);
        control.ScoreAdd(100);
        }
        if(col.tag=="Player")
        {
          Instantiate(playerpatlama,col.transform.position,col.transform.rotation);
          control.GameOver ();
        }
    }
}
