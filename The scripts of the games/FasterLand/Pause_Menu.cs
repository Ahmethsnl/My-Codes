using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool oyundevamediyormu = true;
    public GameObject panelpause;
    public void PauseMenu()
    {
        if (oyundevamediyormu)
        {
            oyundevamediyormu = false;
            Time.timeScale = 0;
            panelpause.SetActive(true);
        }
        else
        {
            oyundevamediyormu = true;
            Time.timeScale = 1;
            panelpause.SetActive(false);
        }
    }
    public void TryAgaiin ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }
    public void QuitGame ()
    {
        Application.Quit ();
    }
}

