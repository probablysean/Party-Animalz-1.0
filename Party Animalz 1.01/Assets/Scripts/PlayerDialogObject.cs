using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogObject : MonoBehaviour
{
    public DialogManagerScript dialogManagerScript;
    public bool InRadius;
    public TestDialogScript currentDialogScript1;

    // Start is called before the first frame update
    void Start()
    {
        dialogManagerScript = GameObject.Find("Dialog Manager").GetComponent<DialogManagerScript>();
       
    }



    public TestDialogScript CheckDialogRadius()
    {
        //replace with radius check later
        currentDialogScript1 = GameObject.Find("TestDialog").GetComponent<TestDialogScript>();

        //return currentDialogScript;
        return currentDialogScript1;
    }

}
