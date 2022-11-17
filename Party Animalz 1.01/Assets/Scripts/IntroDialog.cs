using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroDialog : MonoBehaviour
{

    public PlayerDialogObject PDO;
    public DialogInteractObject DIO;
    public int slide1;
    public Sprite[] dialogOne;
    public Sprite image;
    public GameObject mainImage;
    public GameObject mainButton;

    // Start is called before the first frame update
    void Start()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && PDO.isTalkingPDO == true)
        {
            AddSlide();
        }
    }

    public void AddSlide()
    {
        slide1 += 1;

        mainImage.GetComponent<Image>().sprite = dialogOne[slide1];

        if(slide1 == 1)
        {
            mainImage.SetActive(true);
            mainButton.SetActive(true);
        }

        if (slide1 == 9)
        {
            DIO.EndDialog();
            EndDialog();
        }
    }

    void EndDialog()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PDO.EndDialog();
    }
}
