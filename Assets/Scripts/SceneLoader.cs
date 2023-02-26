using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }
    public void StartScoreScreen(){
        SceneManager.LoadScene(2);
    }

}
