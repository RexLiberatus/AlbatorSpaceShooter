using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        //remplace Jeu par nom ("scene01") ou numéro de scene (1) ou code actuelle 
        //Voir dans File > Build Setting
    }

    public void QuitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }

}
