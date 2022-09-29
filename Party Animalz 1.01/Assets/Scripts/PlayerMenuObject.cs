using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenuObject : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public AudioSource audio1;
    public float slowTrack = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            audio1.pitch = slowTrack;
        }
        else
        {
            Time.timeScale = 1f;
            gamePaused = false;
            Debug.Log("game is playing");
            pauseMenu.SetActive(false);
            pauseButton.SetActive(true);
            audio1.pitch = 1f;
        }
    }
}
