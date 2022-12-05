using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Music

    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller beatScroller;
    public BeatScroller beatScroller2;

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

    public float totalNotes;
    public float normalHits;
    public float goodHits;
    public float perfectHits;
    public float missedHits;

    public GameObject resultsScreen;
    public Text percentHit, goodText, perfectText, missText;

    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentMultiplier = 1;

        totalNotes = FindObjectsOfType<NoteObject>().Length;
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
                beatScroller2.hasStarted = true;

                theMusic.Play();
            }
        }
        else
        {
            if(!theMusic.isPlaying && !resultsScreen.activeInHierarchy && !pauseMenu.activeInHierarchy)
            {
                resultsScreen.SetActive(true);

                string gt = goodHits.ToString();
                goodText.text = gt;

                string pt = perfectHits.ToString();
                perfectText.text = pt;

                string mt = missedHits.ToString();
                missText.text = mt;

                float percHit = (totalNotes - missedHits)*100f / totalNotes;

                string pc = percHit.ToString("F1");
                percentHit.text = pc +" %";
            }
        }
    }

    public void NormalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
        normalHits++;
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
        goodHits++;
    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();
        perfectHits++;
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

        missedHits++;
    }

    #endregion
}
