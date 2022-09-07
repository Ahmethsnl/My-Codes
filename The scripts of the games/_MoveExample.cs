using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MoveExample : MonoBehaviour
{
    public int char_speed;
    public int way_speed;
    private bool fail;
    private Rigidbody rick;
    private bool right,left;

    [SerializeField] private float CoinPoints;

    private void Start()
    {
        rick=GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 turn_right = new Vector3(5,transform.position.y, transform.position.z);

        Vector3 turn_left = new Vector3(-5,transform.position.y, transform.position.z);


        if(fail==true)
        {
            char_speed=0;
            way_speed=0;
        }
        transform.Translate(Vector3.forward*-char_speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right*way_speed*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.right*way_speed*Time.deltaTime);
        }
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-5,5),transform.position.y,transform.position.z);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Coin"))
        {
            CoinPoints++;
        }
    }
}
