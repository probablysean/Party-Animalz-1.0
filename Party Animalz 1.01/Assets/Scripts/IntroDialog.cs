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
    public GameObject mainImage;

    public bool event9 = false;

    // Start is called before the first frame update
    void Start()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    // Update is called once per frame
    void Update()
    {
        slide1 = DIO.slide;

        mainImage.GetComponent<Image>().sprite = dialogOne[slide1];

        if(slide1 == 1)
        {
            //reset events for simple loops at 1
            event9 = false;
        }

        if(slide1 == 9 && event9 == false)
        {
            EndDialog();
            event9 = true;
        }
    }

    void EndDialog()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        PDO.EndDialog();
        DIO.HideButton();
    }
}
