using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogScript : MonoBehaviour
{

    public Sprite[] dialogStart;
    public Sprite[] buttonsBranchA;
    public Sprite[] currentButtons;
    public Sprite[] emptyButtons;

    public Sprite[] dialogA1;
    public Sprite[] buttonBranchA1;
    public Sprite[] dialogA12;
    public Sprite[] dialogA11;
    public Sprite[] buttonBranchA12;
    public Sprite[] buttonBranchA11;
    public Sprite[] dialogA111;
    public Sprite[] dialogA112;
    public Sprite[] dialogA121;
    public Sprite[] dialogA122;

    public Sprite[] dialogA2;
    public Sprite[] buttonBranchA2;
    public Sprite[] dialogA21;
    public Sprite[] dialogA22;
    public Sprite[] buttonBranchA21;
    public Sprite[] buttonBranchA22;
    public Sprite[] dialogA211;
    public Sprite[] dialogA212;
    public Sprite[] dialogA221;
    public Sprite[] dialogA222;

    public Sprite[] currentDialog;
    public int[] dialogArray;
    public int dialogSection = 0;
    public int branchesIndex = 0;

    public void Start()
    {
        currentDialog = dialogStart;
        currentButtons = buttonsBranchA;
    }
    //Send current slide and que up the next one in the array
    public Sprite[] SendDialog()
    {
        return currentDialog;
    }

    //Send the number 
    public int CheckBranches()
    {

        if (currentButtons.Length == 0)
        {
            branchesIndex = 0;
        }
        else
        {
            branchesIndex = 1;
        }

        return branchesIndex;
    }

    public Sprite[] GetButtons()
    {
        return currentButtons;
    }

    public void SetBranch1()
    {
        branchesIndex = 1;

        dialogArray[dialogSection] = 1;

        DialogKing();

    }

    public void SetBranch2()
    {
        branchesIndex = 2;

        dialogArray[dialogSection] = 2;
        

        DialogKing();

        
    }

    //sort the diaglog based on inputs and current section
    public void DialogKing()
    {

        if(dialogSection == 0)
        {
            if(dialogArray[0] == 1)
            {
                currentDialog = dialogA1;
                currentButtons = buttonBranchA1;
            }
            else
            {
                currentDialog = dialogA2;
                currentButtons = buttonBranchA2;
            }
        }

        if(dialogSection == 1)
        {
            if(dialogArray[0] == 1)
            {
                if(dialogArray[1] == 1)
                {
                    currentDialog = dialogA11;
                    currentButtons = buttonBranchA11;
                }
                else
                {
                    currentDialog = dialogA12;
                    currentButtons = buttonBranchA12;
                }
            }
            else
            {
                if (dialogArray[1] == 1)
                {
                    currentDialog = dialogA21;
                    currentButtons = buttonBranchA21;
                }
                else
                {
                    currentDialog = dialogA22;
                    currentButtons = buttonBranchA22;
                }
            }
        }

        if(dialogSection == 2)
        {
            if(dialogArray[0] == 1)
            {
                if(dialogArray[1] == 1)
                {
                    if(dialogArray[2] == 1)
                    {
                        currentDialog = dialogA111;
                        currentButtons = emptyButtons;
                    }
                    else
                    {
                        currentDialog = dialogA112;
                        currentButtons = emptyButtons;
                    }
                }
                else
                {
                    if(dialogArray[2] == 1)
                    {
                        currentDialog = dialogA121;
                        currentButtons = emptyButtons;
                    }
                    else
                    {
                        currentDialog = dialogA122;
                        currentButtons = emptyButtons;
                    }
                }
            }
            else
            {
                if(dialogArray[1] == 1)
                {
                    if (dialogArray[2] == 1)
                    {
                        currentDialog = dialogA211;
                        currentButtons = emptyButtons;
                    }
                    else
                    {
                        currentDialog = dialogA212;
                        currentButtons = emptyButtons;
                    }
                }
                else
                {
                    if(dialogArray[2] == 1)
                    {
                        currentDialog = dialogA221;
                        currentButtons = emptyButtons;
                    }
                    else
                    {
                        currentDialog = dialogA222;
                        currentButtons = emptyButtons;
                    }
                }
            }
        }

        dialogSection += 1;

    }

}
