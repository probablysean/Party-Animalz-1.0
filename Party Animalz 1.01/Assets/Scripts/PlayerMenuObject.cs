using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenuObject : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public AudioSource audio1;



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (gamePaused == false)
        {
            Time.timeScale = 0f;
            gamePaused = true;
            Debug.Log("game is paused");
            pauseMenu.SetActive(true);
            pauseButton.SetActive(false);
            audio1.Pause();
        }
        else
        {
            Time.timeScale = 1f;
            gamePaused = false;
            Debug.Log("game is playing");
            pauseMenu.SetActive(false);
            pauseButton.SetActive(true);
            audio1.Play();
        }
    }
}
