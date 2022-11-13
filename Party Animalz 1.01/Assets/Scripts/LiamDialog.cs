using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LiamDialog : MonoBehaviour
{
    public PlayerDialogObject PDO;
    public DialogInteractObject DIO;
    public int slide1;
    public Sprite[] dialogOne;
    public GameObject mainImage;

    public SceneHandler sceneHandler;

    public bool event4 = false;


    void Awake()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    // Update is called once per frame
    void Update()
    {
        slide1 = DIO.slide;

        mainImage.GetComponent<Image>().sprite = dialogOne[slide1];

        if (slide1 == 1)
        {
            //reset events for simple loops at 1
            event4 = false;
            Time.timeScale = 0f;
        }

        if (slide1 == 4 && event4 == false)
        {
            event4 = true;
            Time.timeScale = 1f;
            LoadTrainingScene();
        }
    }

    void LoadTrainingScene()
    {
        Player player = GameObject.Find("Simba").GetComponent<Player>();

        SceneHandler.SavePlayer();

        SceneManager.LoadScene(5);
    }

}
