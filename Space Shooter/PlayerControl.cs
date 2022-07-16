using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    float vertical   = 0;
    Vector3 vec;
    public float playerspeed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float egim;
    float firetime =0;
    public float atesgecensure; 
    public GameObject Kursun;
    public Transform KursunNeredenCiksin;
    AudioSource audio;
    void Start()
    {
        fizik = GetComponent<Rigidbody> ();
        audio= GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if(Input.GetButton("Fire1")&& Time.time>firetime)
        {
            firetime =Time.time+ atesgecensure;
            Instantiate (Kursun,KursunNeredenCiksin.position,Quaternion.identity);//object pozisyon rotasyon
            audio.Play();
        }        
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3 (horizontal,0,vertical);

        fizik.velocity = vec*playerspeed;

        fizik.position = new Vector3 (
            Mathf.Clamp(fizik.position.x,minX,maxX),
            0.0f,
            Mathf.Clamp(fizik.position.z,minZ,maxZ)
            );
            fizik.rotation = Quaternion.Euler (0,0,fizik.velocity.x*egim);

    }
}
