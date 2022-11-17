using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteractObject : MonoBehaviour
{

    public PlayerDialogObject PDO;

    // Start is called before the first frame update
    void Start()
    { 
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
    }

    public void StartDialog()
    {
        Time.timeScale = 0f;
    }

    public void EndDialog()
    {
        Time.timeScale = 1f;
    }
    public void CloseDialog()
    {
        Destroy(this);
    }

}

