using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerScript : MonoBehaviour
{
    public Sprite image1;
    public TestDialogScript currentDialogScript;
    public PlayerDialogObject playerDialogObject;
    public GameObject currentDialog;
    public int currentSlide;
    public bool isTalking = false;
    public int conversationSize;

    public void Start()
    {
        playerDialogObject = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    public void IsTalkingNow()
    {
        if(isTalking == false)
        {
            StartDialog();
        }
        else
        {
            ContinueDialog();
        }
    }

    public void StartDialog()
    {
        Time.timeScale = 0f;
        currentSlide = 0;

        currentDialogScript = playerDialogObject.CheckDialogRadius();

        if (currentDialogScript != null)
        {
            Debug.Log("Dialog Started");
            isTalking = true;
            conversationSize = currentDialogScript.SendLength();
            ContinueDialog();
        }
        else 
        {
            Debug.Log("No Talkies");
            isTalking = false;
        }
        
    }

    public void ContinueDialog()
    {

        image1 = currentDialogScript.SendImage();

        this.GetComponent<Image>().sprite = image1;

        currentSlide = currentSlide + 1;

        if(currentSlide == conversationSize)
        {
            EndDialog();
        }
    }

    public void EndDialog()
    {
        //Check for Branches

        Time.timeScale = 1f;
        conversationSize = 100;
        currentSlide = 0;
        isTalking = false;
        Debug.Log("Dialog Ended");
    }
}
