using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteractObject : MonoBehaviour
{

    public PlayerDialogObject PDO;
    public GameObject mainButton;
    public int slide;

    // Start is called before the first frame update
    void Start()
    { 
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
        slide = 0;
    }

    public void StartDialog()
    {
        //Turn On Button
        mainButton.SetActive(true);
        slide = 1;
    }

    public void AddSlide()
    {
        slide += 1;
    }

    public void HideButton()
    {
        mainButton.SetActive(false);
    }
}

