using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMainScene : MonoBehaviour
{
    public SceneHandler sceneHandler;


    public void LoadMainScene1()
    {
        SceneManager.LoadScene(2);
    }
}
