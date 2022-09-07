using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Move : MonoBehaviour
{
    [SerializeField] private int char_speed;
    [SerializeField] private int way_speed;
    [SerializeField] private bool right;
    [SerializeField] private bool left;
    private Rigidbody rick;

    void Start()
    {
        rick = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 turn_right = new Vector3(5,transform.position.y,transform.position.z);

        Vector3 turn_left = new Vector3(-5,transform.position.y,transform.position.z);

        transform.Translate(Vector3.forward*-char_speed*Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right*way_speed*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left*way_speed*Time.deltaTime);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-5,5),transform.position.y,transform.position.z);
    }
}
