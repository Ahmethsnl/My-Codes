using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_ : MonoBehaviour 
{
	public float speed;
	private float horizontal;
    public float life = 200;
    private bool oldum_mu = false;
	void Start () 
	{
	}
	void Update () 
	{
		if (life <= 0)
        {
            oldum_mu = true;
            IDie();
        }else{
            oldum_mu = false;
        }
    }
    void IDie()
    {
        Destroy(gameObject);
    }
	void FixedUpdate()
	{
		horizontal = Input.GetAxis ("Horizontal");
		transform.position += new Vector3 (horizontal*speed, 0, 0);

		if (horizontal>0)
        {
            transform.localScale = new Vector3 (7,7,1);
        }
        else if (horizontal<0)
        {
            transform.localScale = new Vector3 (-7,7,1);
        }
	}
}