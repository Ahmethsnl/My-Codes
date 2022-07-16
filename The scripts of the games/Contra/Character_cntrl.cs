using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_cntrl : MonoBehaviour
{
    public float speed;
    private bool ImDie = false;
    private bool ates;
    Animator animasyoncu;
    private float horizontal;
    private float life = 200;
    public Image can_bar;
    private RectTransform rect;
    private bool oldum_mu = false;
    public Transform ates_nesne;
    public GameObject ammo;
    private float ammofirespeed = 0.9f;
    private float ammofirespeedactive = 0;
    void Start()
    {
        animasyoncu = GetComponent<Animator>();
        rect = can_bar.rectTransform;
    }
    void Update()
    {
        if (ammofirespeedactive > 0)
        {
            ammofirespeedactive -= Time.deltaTime;
        }
        if (life <= 0)
        {
            oldum_mu = true;
            animasyoncu.SetBool("ImDeath",oldum_mu);
        }
        rect.sizeDelta = new Vector2(life, rect.sizeDelta.y);
        if (Input.GetKey(KeyCode.Space))
        {
            ates = true;
            if (ammofirespeedactive <= 0)
            {
                GameObject go = Instantiate(ammo, ates_nesne.transform.position,new Quaternion());
                if (transform.localScale.x < 0)
                {
                    go.GetComponent<Ammo_scrpt>().ammo_left();
                }
                ammofirespeedactive = ammofirespeed;
            }
        }
        else
        {
            ates = false;
        }

        animasyoncu.SetBool("ates-ediyor_muyum", ates);
    }

    void FixedUpdate()
    {
        if (ImDie)
        {
            return;
        }

        if (life == 0)
        {
            ImDie = true;
        }
        bool kosuyormuyum = false;
        horizontal = Input.GetAxis("Horizontal");
        float x_hareket  = horizontal * speed * Time.deltaTime;
        transform.position += new Vector3(x_hareket,0,0);
        if (horizontal != 0)
        {
            kosuyormuyum = true;
        }

        animasyoncu.SetBool("kosuyor_muyum", kosuyormuyum);
        YonDuzelt();
    }

    void YonDuzelt()
    {
        if (horizontal < 0)

        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal > 0)

        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Dino")
        {
            life--;
        }
    }

    void IDie()
    {
        Destroy(gameObject);
    }
}
