using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteractObject : MonoBehaviour
{

    public PlayerDialogObject PDO;
    public bool isTalkingDIO;
    public GameObject dialogArrow;

    // Start is called before the first frame update
    void Start()
    { 
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    public void StartDialog()
    {
        Time.timeScale = 0f;
        isTalkingDIO = true;
    }

    public void EndDialog()
    {
        Time.timeScale = 1f;
        isTalkingDIO = false;
    }

    public void CloseDialog()
    {
        this.gameObject.layer = 0;
        dialogArrow.SetActive(false);
    }

}

