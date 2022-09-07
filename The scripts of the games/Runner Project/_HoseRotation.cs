using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _HoseRotation : MonoBehaviour
{
    [SerializeField] private float _rotspeed;

    private Touch _touch;
    private Vector3 _touchDown;
    private Vector3 _touchUp;
    private bool _dragStarted;

    void Update()
    {
        gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation,CalculateRotation(),_rotspeed*Time.deltaTime);
        
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            if (_touch.phase==TouchPhase.Began)
            {
                _dragStarted=true;
            
                _touchDown = _touch.position;
                _touchUp = _touch.position;
            }
        }
        if(_dragStarted)
        {
            if(_touch.phase==TouchPhase.Moved)
            {
                _touchDown=_touch.position;
            }
            if(_touch.phase==TouchPhase.Ended)
            {
                _touchDown=_touch.position;
                _dragStarted=false;
            }
        }
    }

    Quaternion CalculateRotation()
    {
        Quaternion temp = Quaternion.LookRotation(CalculateDirection(), Vector3.up);
        return temp;
    }

    Vector3 CalculateDirection()
    {
        Vector3 temp = (_touchDown-_touchUp);
        // temp.z = temp.y;
        temp.x = temp.y;
        temp.y=0;
        return temp;
    }
}
