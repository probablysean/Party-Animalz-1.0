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

    public bool canTalk;

    private void Start()
    {
        canTalk = true;
        CheckDialogRadius();
    }

    void Update()
    {
        if(Input.GetKey("e") && isTalkingPDO == false && canTalk  == true)
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
            DIO.isTalkingDIO = true;
            isTalkingPDO = true;
            Debug.Log("Start Dialog");
            canTalk = false;
        }
        else
        {
            Debug.Log("No NPC's in radius");
        }
    }

    public void EndDialog()
    {
        DIO.isTalkingDIO = false;
        Debug.Log("End Dialog");
        isTalkingPDO = false;
        StartCoroutine("Timer");
        DIO = null;
    }

    void OnDrawGizmosSelected()
    {
        if (playerCenter == null)
            return;

        Gizmos.DrawWireSphere(playerCenter.position, radius);
    }

    public IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        canTalk = true;
    }
}
