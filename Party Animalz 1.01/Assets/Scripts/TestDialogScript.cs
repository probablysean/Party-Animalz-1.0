using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogScript : MonoBehaviour
{

    public Sprite[] dialogStart;
    public Sprite[] buttonsBranchA;
    public Sprite[] dialogA1;
    public Sprite[] dialogA2;
    public Sprite[] dialogA3;
    public Sprite[] currentDialog;
    public bool branches = false;

    public void Start()
    {
        currentDialog = dialogStart;
    }
    //Send current slide and que up the next one in the array
    public Sprite[] SendDialog()
    {
        return currentDialog;
    }

    //Send the number 
    public bool CheckBranches()
    {
        if (dialogA1.Length == 0)
        {
            branches = false;
        }
        else
        {
            branches = true;
        }
        return branches;
    }

    public Sprite[] GetButtons()
    {

        return buttonsBranchA;
    }
}
