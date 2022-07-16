using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject Astreoid;
    public Vector3 randomPosition;
    public float startwaiting;
    public float olusturmabekleme;
    public float dongubekleme;
    public Text text;
    bool GameOverControl =false;
    bool TryAgainControl =false;
    public Text GameOverText;
    public Text TryAgainText;
    
    int score;
    void Start()
    {
        score=0;
        text.text="score: "+score;
        StartCoroutine (olustur());
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)&& TryAgainControl)
        {
            SceneManager.LoadScene ("Level 1");
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds (startwaiting);
        while(true)
        {
        for( int i = 0; i < 10; i++)
            {
        Vector3 vec = new Vector3 (Random.Range(-randomPosition.x,randomPosition.x),0,randomPosition.z);
        Instantiate(Astreoid,vec,Quaternion.identity);
        yield return new WaitForSeconds (olusturmabekleme);
            }
            if(GameOverControl)
            {
            TryAgainText.text="Try Again For Press R";
            TryAgainControl =true;
            break;
            }
        yield return new WaitForSeconds (dongubekleme); 
        }        
    }
    public void ScoreAdd(int GelenScore)
    {
        score+=GelenScore;
        text.text="score: "+score;
    }
    public void GameOver()
    {
        GameOverText.text="Game Over";
        GameOverControl=true;
    }
}
