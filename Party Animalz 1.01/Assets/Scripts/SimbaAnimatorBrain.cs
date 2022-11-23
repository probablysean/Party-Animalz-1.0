using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimbaAnimatorBrain : MonoBehaviour
{

    public Animator simbaAnimator;

    public float yAxis;
    public float xAxis;
    public bool moving;

    // Start is called before the first frame update
    void Start()
    {
        xAxis = 0;
        yAxis = 0;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        #region isMoving
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        #endregion

        if (Input.GetKeyDown("s"))
        {
            yAxis = -1;
            xAxis = 0;
        }

        if (Input.GetKeyDown("w"))
        {
            yAxis = 1;
            xAxis = 0;
        }

        if (Input.GetKeyDown("d"))
        {
            xAxis = 1;
            yAxis = 0;
        }

        if (Input.GetKeyDown("a"))
        {
            xAxis = -1;
            yAxis = 0;
        }

        simbaAnimator.SetFloat("xAxis", xAxis);
        simbaAnimator.SetFloat("yAxis", yAxis);
        simbaAnimator.SetBool("moving", moving);
    }
}
