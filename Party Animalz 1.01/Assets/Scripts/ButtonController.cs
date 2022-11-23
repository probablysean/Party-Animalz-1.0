using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public GameObject image;
    public Sprite defaultImage;
    public Sprite activeImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            image.GetComponent<Image>().sprite = activeImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            image.GetComponent<Image>().sprite = defaultImage;
        }
    }
}
