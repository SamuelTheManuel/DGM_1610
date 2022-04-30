using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    // Start is called before the first frame update

    public void StartGame(){
        SceneManager.LoadScene(sceneToLoad); // scene to load
    }
    public void QuitGame() {
        //application.quit only works when you build the final game
        Debug.Log("Quit Game");
        Application.Quit();

    }
}
