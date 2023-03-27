using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SitchAndAdamDialog : MonoBehaviour
{
    public PlayerDialogObject PDO;
    public DialogInteractObject DIO;
    public int slide1;
    public Sprite[] dialogOne;
    public Sprite[] dialogTwo;
    public GameObject mainImage;
    public Sprite image;
    public GameObject mainButton;
    public GameObject button1;
    public GameObject button2;

    public SceneHandler sceneHandler;
    public bool choices = false;
    public bool dialogStarted;
    public bool option1 = true;



    void Awake()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
        option1 = true;
        choices = false;
        dialogStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && DIO.isTalkingDIO == true && choices == false)
        {
            AddSlide();
        }

        if (DIO.isTalkingDIO == true && dialogStarted == false)
        {
            dialogStarted = true;
            AddSlide();
        }
    }

    public void AddSlide()
    {
        slide1 += 1;
        Debug.Log(slide1);

        if (option1 == true)
        {
            mainImage.GetComponent<Image>().sprite = dialogOne[slide1];
        }
        else
        {
            if (slide1 >= 7)
            {
                mainImage.GetComponent<Image>().sprite = dialogTwo[slide1 - 7];
            }
            else
            {
                mainImage.GetComponent<Image>().sprite = dialogOne[slide1];
            }
        }

        if (slide1 == 1)
        {
            mainImage.SetActive(true);
            mainButton.SetActive(true);
        }

        if (slide1 == 6)
        {
            Choices();
        }

        if (slide1 == 9 && option1 == true)
        {
            EndDialog();
            DIO.CloseDialog();
        }

        if (slide1 == 11 && option1 == false)
        {
            EndDialog();
            DIO.CloseDialog();
        }

    }


    public void Choices()
    {
        mainImage.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        mainButton.SetActive(false);
        choices = true;
    }

    public void EndChoices()
    {
        mainButton.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        AddSlide();
        choices = false;
    }

    public void Button1()
    {
        option1 = true;
        EndChoices();
    }

    public void Button2()
    {
        option1 = false;
        EndChoices();
    }

    void EndDialog()
    {
        DIO.EndDialog();
        PDO.EndDialog();

        mainButton.SetActive(false);
        mainImage.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);

        dialogStarted = false;
    }
}
