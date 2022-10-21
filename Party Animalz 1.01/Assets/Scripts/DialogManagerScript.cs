using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagerScript : MonoBehaviour
{
    public Sprite[] currentDialog;
    public TestDialogScript currentDialogScript;
    public PlayerDialogObject playerDialogObject;
    public int currentSlide;
    public bool isTalking = false;
    public int conversationSize;
    public bool branches = false;
    public Sprite[] currentButtons;
    public GameObject button1;
    public GameObject button2;
    public GameObject mainButton;


    //find player object to use for radius detection later
    public void Start()
    {
        playerDialogObject = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    //This script is called first by the button to continue or start dialog
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

    //Is called if there is no current dialog to check for new scripts
    public void StartDialog()
    {
        //pause game and reset variables
        Time.timeScale = 0f;
        currentSlide = 0;

        //call player object to check for radius of script or npc's
        currentDialogScript = playerDialogObject.CheckDialogRadius();

        if (currentDialogScript != null)
        {
            //start dialog and find the total slide length
            Debug.Log("Dialog Started");
            isTalking = true;

            mainButton.SetActive(true);

            currentDialog = currentDialogScript.SendDialog();

            conversationSize = currentDialog.Length;

            ContinueDialog();
        }
        else 
        {
            //no script can be found
            Debug.Log("No Talkies");
            isTalking = false;
        }
    }

    //get next image and check to see if the final slide has been played
    public void ContinueDialog()
    {
        this.GetComponent<Image>().sprite = currentDialog[currentSlide];

        currentSlide = currentSlide + 1;

        if(currentSlide == conversationSize)
        {
            EndDialog();
        }
    }

    //Checks to see if dialog should end or branch to the next dialog
    public void EndDialog()
    {
        //Check for Branches
        branches = currentDialogScript.CheckBranches();

        currentSlide = 0;

        if (branches == false)
        {
            //close dialog
            Time.timeScale = 1f;
            conversationSize = 100;
            currentSlide = 0;
            isTalking = false;
            mainButton.SetActive(false);
            Debug.Log("Dialog Ended");
        }
        else
        {
            //open buttons
            currentButtons = currentDialogScript.GetButtons();

            //2 Buttons
            if (currentButtons.Length == 2)
            {
                button1.SetActive(true);
                button1.GetComponent<Image>().sprite = currentButtons[0];

                button2.SetActive(true);
                button2.GetComponent<Image>().sprite = currentButtons[1];
            }

            mainButton.SetActive(false);

        }
      
    }


}
