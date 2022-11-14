using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler 
{
    public static Player player;
    public static Vector2 movePlayer;
    public static GameObject simba;
    public static Vector2 savedPosition;



    public static void SavePlayer()
    {
        savedPosition = GameObject.Find("Simba").transform.position;
        //Debug.Log(savedPosition.x +","+ savedPosition.y);
        SaveDialog();
    }

    public static void LoadPlayer()
    {
        //Debug.Log("Move Player");
        //Debug.Log(savedPosition.x + "," + savedPosition.y);

        //find transform
        simba = GameObject.Find("Simba");
        Transform simbaPosition = simba.GetComponent<Transform>();

        //move player
        simbaPosition.position = savedPosition;


    }

    public static void SaveDialog()
    {

    }


}
