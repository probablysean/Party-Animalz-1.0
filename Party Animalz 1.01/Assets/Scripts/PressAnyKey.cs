using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyKey : MonoBehaviour
{

    public GameObject image;


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            image.SetActive(false);
        }
    }
}
