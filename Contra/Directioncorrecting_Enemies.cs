using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directioncorrecting_Enemies : MonoBehaviour
{
    public LayerMask layer;
    public Enemies dino_hareket;
    public Transform dino;
    void Start()
    {
        dino = transform.parent;
        dino_hareket = dino.GetComponent<Enemies>();
    }

    void Update()
    {
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.down, 0.3f, layer);
        if (Hit.collider == null)
        {
            
            dino.localScale = new Vector3(dino.localScale.x * -1, dino.localScale.y, dino.localScale.z);
            dino_hareket.speed *= -1;
        }
        
    }
}
