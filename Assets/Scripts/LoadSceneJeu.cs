using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneJeu : MonoBehaviour
{
    public void LoadJeu ()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
