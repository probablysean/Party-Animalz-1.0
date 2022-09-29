using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogObject : MonoBehaviour
{
    public DialogManagerScript dialogManagerScript;
    public bool reading = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogManagerScript = GameObject.Find("Dialog Manager").GetComponent<DialogManagerScript>(); ;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && reading == false)
        {
            StartCoroutine(IsReading());
            //Debug.Log("test");
            dialogManagerScript.Dialog();
        }
    }

    IEnumerator IsReading()
    {
        //Debug.Log("test");
        reading = true;
        yield return new WaitForSeconds(1);
        reading = false;
    }
     
}
