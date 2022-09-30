using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerScript : MonoBehaviour
{
    public Sprite image1;
    public TestDialogScript currentDialogScript;
    public GameObject currentDialog;
    public int currentSlide;


    public void Dialog()
    {
        //Change to looking for tags later
        currentDialog = GameObject.Find("TestDialog");
        currentDialogScript = currentDialog.GetComponent<TestDialogScript>();

        image1 = currentDialogScript.SendImage();

        this.GetComponent<Image>().sprite = image1;
    }
}
