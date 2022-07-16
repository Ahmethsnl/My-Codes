using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Transition : MonoBehaviour
{
    public void TryAgain ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
    }
}
