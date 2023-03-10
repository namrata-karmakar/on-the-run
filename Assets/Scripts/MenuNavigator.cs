using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }
    public void LevelSelector(){
        SceneManager.LoadScene(2);
    }
    public void StartMenu(){
        SceneManager.LoadScene(0);
    }
    public void ScoreList(){
        SceneManager.LoadScene(3);
    }
    public void CloseGame(){
        Application.Quit();
    }

}
