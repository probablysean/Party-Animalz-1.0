using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogScript : MonoBehaviour
{

    public Sprite[] dialogStart;
    public Sprite[] buttonsBranchA;
    public Sprite[] currentButtons;

    public Sprite[] dialogA1;
    public Sprite[] dialogA12;
    public Sprite[] dialogA11;

    public Sprite[] dialogA2;
    public Sprite[] dialogA21;
    public Sprite[] dialogA22;

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

        if (dialogA1.Length == 0)
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
            }
            else
            {
                currentDialog = dialogA2;
            }
        }

        if(dialogSection == 1)
        {
            if(dialogArray[0] == 1)
            {
                if(dialogArray[1] == 1)
                {
                    currentDialog = dialogA11;
                }
                else
                {
                    currentDialog = dialogA12;
                }
            }
            else
            {
                if (dialogArray[1] == 1)
                {
                    currentDialog = dialogA21;
                }
                else
                {
                    currentDialog = dialogA22; 
                }
            }


        }

        dialogSection += 1;

    }

}
