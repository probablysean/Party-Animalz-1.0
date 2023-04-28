using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int trueStart;


    public void Awake()
    {
        trueStart = SceneHandler.TrueStart();

        if(trueStart > 1)
        {
            SceneHandler.LoadPlayer();
        }
    }

}
