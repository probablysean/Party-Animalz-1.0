using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller beatScroller;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                beatScroller.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("hit on time");

        currentScore += scorePerNote;

    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
