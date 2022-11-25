using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    private bool obtained = false;

    public GameObject hitEffect, goodEffect, perfectEffect, missedEffect;



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.y);

        if(Input.GetKeyDown(keyToPress) || Input.GetKeyDown(keyToPress2))
        {
            if(canBePressed == true)
            {
                obtained = true;
                gameObject.SetActive(false);
                
                //GameManager.instance.NoteHit();

                if(transform.position.y > -3.69 || transform.position.y < -3.81)
                { 
                    GameManager.instance.NormalHit();
                    //Debug.Log("Nice");
                    //Instantiate(hitEffect, transform.position, hitEffect.transform.rotation) ;
                    GameObject e1 = Instantiate(hitEffect, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                    e1.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                    e1.transform.position = transform.position;
                    e1.transform.rotation = hitEffect.transform.rotation;


                }
                else if(transform.position.y > -3.73 || transform.position.y < -3.77)
                {
                    GameManager.instance.GoodHit();
                    //Debug.Log("Good");
                    //Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                    GameObject e1 = Instantiate(goodEffect, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                    e1.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                    e1.transform.position = transform.position;
                    e1.transform.rotation = hitEffect.transform.rotation;
                }
                else
                {
                    GameManager.instance.PerfectHit();
                    //Debug.Log("Perfect");
                    //Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                    GameObject e1 = Instantiate(perfectEffect, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                    e1.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                    e1.transform.position = transform.position;
                    e1.transform.rotation = perfectEffect.transform.rotation;
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
                //Instantiate(missedEffect, transform.position, missedEffect.transform.rotation);
                GameObject e1 = Instantiate(missedEffect, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                e1.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                e1.transform.position = transform.position;
                e1.transform.rotation = missedEffect.transform.rotation;
            }
        }
    }
}
