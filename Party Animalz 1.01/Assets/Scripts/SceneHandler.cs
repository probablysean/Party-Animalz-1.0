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
    public static int liamDIO;
    public static int felicaDialogSlide;
    public static int felicaDIO;
    public static int bladeDialogSlide;
    public static int BladeDIO;

    public static int trueStart = 0;

    public static void SavePlayer()
    {
        //player
        savedPosition = GameObject.Find("Simba").transform.position;

        //liam
        liamDialogSlide = GameObject.Find("LiamDialog").GetComponent<LiamDialog>().slide1;
        liamDIO = GameObject.Find("LiamDIO").layer;

        //Felica
        felicaDialogSlide = GameObject.Find("FelicaDialog").GetComponent<felicadialogue>().slide1;
        felicaDIO = GameObject.Find("felicaDIO").layer;

        //Blade
        bladeDialogSlide = GameObject.Find("BladeDialog").GetComponent<BladeDialog>().slide1;
        BladeDIO = GameObject.Find("BladeDIO").layer;
    }

    public static void LoadPlayer()
    {
        //player
        simba = GameObject.Find("Simba");
        Transform simbaPosition = simba.GetComponent<Transform>();
        simbaPosition.position = savedPosition;

        //liam
        GameObject.Find("LiamDialog").GetComponent<LiamDialog>().slide1 = liamDialogSlide;
        GameObject.Find("LiamDIO").layer = liamDIO;

        //Felica
        GameObject.Find("FelicaDialog").GetComponent<felicadialogue>().slide1 = felicaDialogSlide;
        GameObject.Find("felicaDIO").layer = felicaDIO;

        //Blade
        GameObject.Find("BladeDialog").GetComponent<BladeDialog>().slide1 = bladeDialogSlide;
        GameObject.Find("BladeDIO").layer = BladeDIO;

    }

    //Stops loading on the first start
    public static int TrueStart()
    {
        if(trueStart < 2)
        {
            trueStart++;
        }

        return trueStart;
    }

}
