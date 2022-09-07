using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SwerveMeck : MonoBehaviour
{

    [SerializeField] private float _forwardSpeed =5f;
    [SerializeField] private float _lerpSpeed =5f;
    [SerializeField] private float _playerXValue =2f;
    [SerializeField] private Vector2 _clampValues = new Vector2 (-2,2);
    [SerializeField] private float newXPos;
    [SerializeField] private float startXPos;

    private Rigidbody _rb; 

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            newXPos = Mathf.Clamp(transform.position.x+Input.GetAxisRaw ("Horizontal")* _playerXValue,startXPos+ _clampValues.x,startXPos + _clampValues.y );
        }
    }

    void FixedUpdate()
    {
        // Player Movement
        _rb.MovePosition(new Vector3(Mathf.Lerp(transform.position.x,newXPos,_lerpSpeed*Time.fixedDeltaTime),_rb.velocity.y,transform.position.z+_forwardSpeed*Time.fixedDeltaTime));
    }
}
