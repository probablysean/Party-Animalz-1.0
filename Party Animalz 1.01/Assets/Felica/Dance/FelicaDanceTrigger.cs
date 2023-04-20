using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FelicaDanceTrigger : MonoBehaviour
{
    public Animator felicaAnimator;
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
            if (dancing == false)
            {
                Debug.Log(xAxis +", " + yAxis);
                StartCoroutine("DanceTime");
                felicaAnimator.SetFloat("xAxis", xAxis);
                felicaAnimator.SetFloat("yAxis", yAxis);
            }
        }
    }

    IEnumerator DanceTime()
    {
        felicaAnimator.SetBool("Dancing", true);
        yield return new WaitForSeconds(danceTime);
        felicaAnimator.SetBool("Dancing", false);
    }
}
