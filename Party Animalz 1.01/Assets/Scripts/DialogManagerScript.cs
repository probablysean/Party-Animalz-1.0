using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManagerScript : MonoBehaviour
{
    public GameObject image;
    public GameObject testDialog;

    // Start is called before the first frame update
    void Start()
    {
        testDialog = GameObject.Find("TestDialog");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Dialog()
    {
        Debug.Log("test");
    }
}
