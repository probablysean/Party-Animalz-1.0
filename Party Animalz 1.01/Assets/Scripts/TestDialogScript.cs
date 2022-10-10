using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogScript : MonoBehaviour
{

    public Sprite[] dialogStart;
    public Sprite[] buttonsBranchA;
    public Sprite[] currentDialog;
    public bool branches;

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
        return branches;
    }

    public Sprite[] GetButtons()
    {

        return buttonsBranchA;
    }
}
