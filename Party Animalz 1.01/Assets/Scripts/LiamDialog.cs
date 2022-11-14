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
    public Sprite[] dialogTwo;
    public GameObject mainImage;
    public Sprite image;
    public GameObject mainButton;
    public GameObject button1;
    public GameObject button2;

    public SceneHandler sceneHandler;
    public bool choices = false;

    public bool option1 = true;

    void Awake()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
        option1 = true;
        choices = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && PDO.isTalkingPDO == true && DIO.isTalkingDIO == true && choices == false)
        {
            AddSlide();
        }
    }

    public void AddSlide()
    {
        slide1 += 1;

        if (option1 == true )
        {
            mainImage.GetComponent<Image>().sprite = dialogOne[slide1];
        }
        else
        {
            if(slide1 >= 5)
            {
                mainImage.GetComponent<Image>().sprite = dialogTwo[slide1 - 5];
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

        if (slide1 == 4)
        {
            Choices();
        }
        
        if(slide1 == 6 && option1 == true)
        {
            slide1 = 3;
            LoadTrainingScene();
        }

        if (slide1 == 6 && option1 == false)
        {
            slide1 = 3;
            EndDialog();
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

    void LoadTrainingScene()
    {
        Time.timeScale = 1f;

        SceneHandler.SavePlayer();

        SceneManager.LoadScene(5);
    }

    void EndDialog()
    {
        DIO.EndDialog();
        PDO.EndDialog();

        mainButton.SetActive(false);
        mainImage.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
    }

}
