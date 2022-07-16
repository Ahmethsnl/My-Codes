using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpe : MonoBehaviour
{
    public LayerMask layer;
    public Rigidbody2D rigid;
    public bool yerdemi = false;
    public float ziplama;
    public float jump_power;
    void Start()
    {
    }
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, jump_power, layer);
        if (hit.collider != null)
        {
            yerdemi = true;
        }
        else
        {
            yerdemi = false;
        }

        if (Input.GetKeyDown(KeyCode.W)&& yerdemi)
        {
            rigid.velocity += new Vector2(0, ziplama);
        }
    }
    
}
