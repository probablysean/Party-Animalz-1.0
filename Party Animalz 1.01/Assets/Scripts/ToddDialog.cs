using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToddDialog : MonoBehaviour
{
    public PlayerDialogObject PDO;
    public DialogInteractObject DIO;
    public int slide1;
    public Sprite[] dialogOne;
    public GameObject mainImage;
    public Sprite image;
    public GameObject mainButton;

    public SceneHandler sceneHandler;
    public bool dialogStarted;


    void Awake()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
        dialogStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && DIO.isTalkingDIO == true && dialogStarted == true)
        {
            AddSlide();
        }

        //start dialog skip bug correction
        if (DIO.isTalkingDIO == true && dialogStarted == false)
        {
            dialogStarted = true;
            AddSlide();
        }
    }

    public void AddSlide()
    {
        slide1 += 1;

        mainImage.GetComponent<Image>().sprite = dialogOne[slide1];

        if (slide1 == 1)
        {
            mainImage.SetActive(true);
            mainButton.SetActive(true);
        }

        if (slide1 == 2)
        {
            EndDialog();
            DIO.CloseDialog();
        }
    }    

    void EndDialog()
    {
        DIO.EndDialog();
        PDO.EndDialog();

        mainButton.SetActive(false);
        mainImage.SetActive(false);

        dialogStarted = false;
    }
}
