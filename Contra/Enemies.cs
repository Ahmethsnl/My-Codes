using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public LayerMask layer;
	public float run_speed;
	private float speed_end;
    public float speed;
	private bool gordum_mu;
	public Animator animasyoncum;
	private bool temas = false;
	private bool oldum=false;
	void Start()
    {
        animasyoncum = GetComponent<Animator> ();
        if (transform.localScale.x< 0)
        {
	        speed *= -1;
        }
    }
    void FixedUpdate()
    {
		if(oldum)
		{
			return;
		}
	    speed_end = speed;
		if(gordum_mu)
		{
		speed_end = speed * run_speed;
		}
		if (temas==false || gordum_mu == false)
		{ 
			transform.position += new Vector3(speed_end * Time.deltaTime, 0, 0);
		}
		gordum_mu = goruyormu ();
		animasyoncum.SetBool ("kosuyor_mu",gordum_mu);
    }
    private bool goruyormu ()
    {
        Vector2 yon;
        if(transform.localScale.x>0) 
        {
            yon = Vector2.right;
        }
        else 
        {
            yon = Vector2.left;
        }
        RaycastHit2D hit = Physics2D.Raycast (transform.position, yon,6f,layer);
		if (hit.collider == null) 
		{
			return false;
		}
		else
		{
			return true;
		}
    }
	void OnCollisionEnter2D(Collision2D coll)
    {
	    if (coll.gameObject.tag == "Karakter")
	    {
		    temas = true;
	    }
    }
	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Karakter")
		{
			temas = false;
		}
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.tag == "ammo")
		{
			animasyoncum.SetBool ("oldu_mu",true);
			Destroy(coll.gameObject);
			oldum=true;
		}
	}
	void Die()
	{
		Destroy(gameObject);	
	}
}