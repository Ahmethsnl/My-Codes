using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character_Control : MonoBehaviour
{
    public float hiz;
    public Animator anismasyoncu;
    private int totalgold;
    public Text texttotalgold;
    public GameObject pnl_GameOver;
    public Text text_score;
    private bool kosuyormuyum ;
    public static bool Oyunbasladimi =false;
    public GameObject pnl_oyun_basi;
    public AudioSource ses_altin;
    public AudioSource ses_die;
    private float horizontal;
    public int kacincilevel = 1;
    void Start()
    {
        Oyunbasladimi=false;
    }
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        Oldum_mu ();
        if(Oyunbasladimi == false)
        {
            return;
        }
       // float horizontal = Input.GetAxis("Horizontal");
        // -1 ile 1 aralığında değişiyor sol(a) sağ(d) 0 sa hiçbir tuşa basmıyoruz
        if (horizontal != 0)
        {
            kosuyormuyum = true;
            anismasyoncu.speed = Mathf.Abs (horizontal);
        }
        else 
        {
            anismasyoncu.speed = Mathf.Abs (1);
        }
        anismasyoncu.SetBool("Kosuyorum", kosuyormuyum);
        transform.position += new Vector3(horizontal*hiz*Time.deltaTime,0,0);

        if (horizontal>0)
        {
            transform.localScale = new Vector3 (1,1,1);
        }
        else if (horizontal<0)
        {
            transform.localScale = new Vector3 (-1,1,1);
        }
    }
    void OnTriggerEnter2D(Collider2D carpilannesne)
    {
        if(carpilannesne.CompareTag("coin"))
        {
            totalgold++;
            texttotalgold.text = totalgold.ToString ();
            ses_altin.Play ();
            Destroy (carpilannesne.gameObject);
        }
        else if(carpilannesne.tag=="Tuzak")
        {
            Die ();
        }

        else if (carpilannesne.tag=="Kapi")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (PlayerPrefs.GetInt("level")<kacincilevel)
            {
                PlayerPrefs.SetInt("level",kacincilevel);
            }
            //birinci level geçilince kayıt dosyasında 1 yazacak
        }
        
    }
    void Die () 
        {
            ses_die.Play ();
            Destroy (gameObject);
            pnl_GameOver.SetActive (true); 
            text_score.text = texttotalgold.text;
        }
    public void oyunbasladi ()
    {
        Oyunbasladimi=true;
        pnl_oyun_basi.SetActive  (false);
    }
    void Oldum_mu ()
    {
        if(transform.position.y <-5f)
        {
            Die ();
        }
    }

    public void hareket(int miktar)
    {
        horizontal = miktar;
    }
}
