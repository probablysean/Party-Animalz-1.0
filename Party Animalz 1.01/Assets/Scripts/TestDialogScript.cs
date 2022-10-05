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

            InDialog();
          
        }
        else
        {
            slide = 0;
        }
       
        return currentSlide;
    }

    public void InDialog()
    {
        if (slide == testDialog.Length)
        {
            slide = 0;
        }
      
    }

    public int SendLength()
    {
        return testDialog.Length;
    }
}
