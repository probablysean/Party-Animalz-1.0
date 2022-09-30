using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDialogScript : MonoBehaviour
{

    public Sprite[] testDialog;
    public int slide = 0;
    public Sprite currentSlide; 

  
    public Sprite SendImage()
    {
        

        if (slide < testDialog.Length)
        {
            
            currentSlide = testDialog[slide];
            slide = slide + 1;

            if(slide == testDialog.Length)
            {
                Time.timeScale = 1f;
                slide = 0;
            }
            else
            {
                Time.timeScale = 0f;
            }
            
        }
        else
        {
            slide = 0;
        }
       
        return currentSlide;
    }
}
