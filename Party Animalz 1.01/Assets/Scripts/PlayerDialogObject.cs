using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogObject : MonoBehaviour
{
    public DialogManagerScript dialogManagerScript;
    public bool reading = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogManagerScript = GameObject.Find("Dialog Manager").GetComponent<DialogManagerScript>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && reading == false)
        {
            dialogManagerScript.Dialog();
        }
    }


     
}
