using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialog : MonoBehaviour
{

    public PlayerDialogObject PDO;
    public DialogInteractObject DIO;
    public int slide1;
    public Sprite[] dialogOne;
    public GameObject mainImage;

    public bool event4 = false;

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
            event4 = false;
        }

        if(slide1 == 4 && event4 == false)
        {
            EndDialog();
            event4 = true;
        }
    }

    void EndDialog()
    {
        PDO.EndDialog();
        DIO.HideButton();
    }
}
