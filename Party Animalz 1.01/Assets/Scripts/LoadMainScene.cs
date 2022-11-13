using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMainScene : MonoBehaviour
{
    public SceneHandler sceneHandler;

    public void Start()
    {
        sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
    }
    public void LoadMainScene1()
    {
        sceneHandler.LoadPlayer();
        SceneManager.LoadScene(2);
    }
}
