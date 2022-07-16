using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healt_bar : MonoBehaviour
{
    public float can,animasyonyavasligi;   
    private float Maxcan  , gercekScale;

    void Start()
    {
        Maxcan = can;
    }


    void Update()
    {
        gercekScale = can/Maxcan;
        if(transform.localScale.x > gercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x-gercekScale)/animasyonyavasligi,transform.localScale.y,transform.localScale.z);
        }

        if(transform.localScale.x < gercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + (gercekScale-transform.localScale.x)/animasyonyavasligi,transform.localScale.y,transform.localScale.z);
        }

        if(Input.GetKeyDown("w")&& can> 0){
            can -=10;
        }

        if(Input.GetKeyDown("r")){
            can +=25;
        }

        if (can<0){
            can=0;
        }
        if(can>Maxcan){
            can = Maxcan;
        }
    }
}
