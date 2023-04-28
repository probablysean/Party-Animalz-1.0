using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimbaFelicaDanceAnimatorBrain : MonoBehaviour
{
    public Animator simbaAnimator;

    public float yAxis;
    public float xAxis;
    public bool dancing;
    public float danceTime = 0.4f;

    void Start()
    {
        xAxis = 0;
        yAxis = 0;
        dancing = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine("DanceTime");
        }

        if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow))
        {
            yAxis = -1;
            xAxis = 0;
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            yAxis = 1;
            xAxis = 0;
        }

        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            xAxis = 1;
            yAxis = 0;
        }

        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            xAxis = -1;
            yAxis = 0;
        }

        simbaAnimator.SetFloat("xAxis", xAxis);
        simbaAnimator.SetFloat("yAxis", yAxis);
    }

    IEnumerator DanceTime()
    {
        simbaAnimator.SetBool("Dancing", true);
        yield return new WaitForSeconds(danceTime);
        simbaAnimator.SetBool("Dancing", false);
    }
}
