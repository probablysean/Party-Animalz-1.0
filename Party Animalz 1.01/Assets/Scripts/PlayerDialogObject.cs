using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogObject : MonoBehaviour
{
    public bool InRadius;
    public float Radius;
    public DialogInteractObject DIO;
    public bool isTalking = false;

    void Update()
    {
        if(Input.GetKey("e") && isTalking == false)
        {
            CheckDialogRadius();
        }
    }

    public void CheckDialogRadius()
    {
        //Check Radius later
        DIO = GameObject.Find("DialogInteractObject").GetComponent<DialogInteractObject>();

        if(DIO != null)
        {
            DIO.StartDialog();
            isTalking = true;
            Debug.Log("Start Dialog");
        }
        else
        {
            Debug.Log("No NPC's in radius");
        }
    }

    public void EndDialog()
    {
        isTalking = false;
        Debug.Log("End Dialog");
    }

}
