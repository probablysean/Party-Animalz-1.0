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

    public static int liamDialogSlide;

    public static void SavePlayer()
    {
        //player
        savedPosition = GameObject.Find("Simba").transform.position;

        //liam
        liamDialogSlide = GameObject.Find("LiamDialog").GetComponent<LiamDialog>().slide1;
    }

    public static void LoadPlayer()
    {
        //player
        simba = GameObject.Find("Simba");
        Transform simbaPosition = simba.GetComponent<Transform>();
        simbaPosition.position = savedPosition;

        //liam
        GameObject.Find("LiamDialog").GetComponent<LiamDialog>().slide1 = liamDialogSlide;
        Debug.Log(GameObject.Find("LiamDialog").GetComponent<LiamDialog>().slide1);
    }

}
