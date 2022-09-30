using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool gamePaused = false;
    // Start is called before the first frame update

    public void PauseGame()
    {
        if (gamePaused == false)
        {
            Time.timeScale = 0f;
            gamePaused = true;
            Debug.Log("game is paused");
        }
        else
        {
            Time.timeScale = 1f;
            gamePaused = false;
            Debug.Log("game is playing");
        }
    }
}
