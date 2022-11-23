using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogObject : MonoBehaviour
{
    public bool InRadius;
    public float radius;
    public DialogInteractObject DIO;
    public bool isTalkingPDO = false;
    public LayerMask npcLayer;
    public Transform playerCenter;

    void Update()
    {
        if(Input.GetKey("e") && isTalkingPDO == false)
        {
            CheckDialogRadius();
        }
    }

    public void CheckDialogRadius()
    {
        //Check Radius later
        //DIO = GameObject.Find("DialogInteractObject").GetComponent<DialogInteractObject>();

        Collider2D[] npcs = Physics2D.OverlapCircleAll(playerCenter.position, radius, npcLayer);

        foreach(Collider2D npc in npcs)
        {
            DIO = npc.GetComponent<DialogInteractObject>();
        }

        if(DIO != null)
        {
            DIO.StartDialog();
            isTalkingPDO = true;
            Debug.Log("Start Dialog");
        }
        else
        {
            Debug.Log("No NPC's in radius");
        }
    }

    public void EndDialog()
    {
        isTalkingPDO = false;
        Debug.Log("End Dialog");
    }

    void OnDrawGizmosSelected()
    {
        if (playerCenter == null)
            return;

        Gizmos.DrawWireSphere(playerCenter.position, radius);
    }

}
