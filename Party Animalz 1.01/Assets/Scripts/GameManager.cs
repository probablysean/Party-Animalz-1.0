using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller beatScroller;

    public static GameManager instance;

    public Text scoreText;
    public Text multiText;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 250;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    private string score;
    private string cM;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentMultiplier = 1;
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

    public void NormalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();
    }

    public void NoteHit()
    {
        //Debug.Log("hit on time");
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;

            }
        }

        cM = currentMultiplier.ToString();
        multiText.text = "x" + cM;

        //currentScore += scorePerNote * currentMultiplier;

        score = currentScore.ToString();
        scoreText.text = score;

    }

    public void NoteMissed()
    {
        //Debug.Log("Missed");
        currentMultiplier = 1;
        multiplierTracker = 0;

        cM = currentMultiplier.ToString();
        multiText.text = "x" + cM;
    }
}
