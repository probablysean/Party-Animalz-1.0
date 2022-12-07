using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiamDanceTrigger : MonoBehaviour
{

    public Animator liamAnimator;
    public float yAxis;
    public float xAxis;
    public bool dancing;
    public float danceTime = 0.2f;

    void Start()
    {
        dancing = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            if(dancing == false)
            {
                //Debug.Log(xAxis +", " + yAxis);
                StartCoroutine("DanceTime");
                liamAnimator.SetFloat("xAxis", xAxis);
                liamAnimator.SetFloat("yAxis", yAxis);
            }
        }
    }

    IEnumerator DanceTime()
    {
        liamAnimator.SetBool("Dancing", true);
        yield return new WaitForSeconds(danceTime);
        liamAnimator.SetBool("Dancing", false);
    }
}
