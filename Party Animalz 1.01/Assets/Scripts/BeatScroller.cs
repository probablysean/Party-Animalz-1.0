using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;
    public float tempoConstant = 1f;

    public bool hasStarted;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            //if(Input.anyKeyDown)
            {
                //hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * tempoConstant / 60f * Time.deltaTime, 0f);
        }
    }


}
