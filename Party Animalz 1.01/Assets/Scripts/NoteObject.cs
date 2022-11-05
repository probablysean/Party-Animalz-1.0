using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;

    private bool obtained = false;



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.y);

        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed == true)
            {
                obtained = true;
                gameObject.SetActive(false);
                
                //GameManager.instance.NoteHit();

                if(transform.position.y > -3.60 || transform.position.y < -3.90)
                { 
                    GameManager.instance.NormalHit();
                    Debug.Log("Nice");
                }
                else if(transform.position.y > -3.72 || transform.position.y < -3.78)
                {
                    GameManager.instance.GoodHit();
                    Debug.Log("Good");
                }
                else
                {
                    GameManager.instance.PerfectHit();
                    Debug.Log("Perfect");
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if(!obtained)
            {
                GameManager.instance.NoteMissed();
            }
        }
    }
}
