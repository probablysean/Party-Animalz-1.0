using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrap : MonoBehaviour
{

    public Transform center;
    public float radius = 0.75f;
    public PlayerDialogObject PDO;

    void ForceDialog()
    {
        PDO = GameObject.Find("PlayerDialogObject").GetComponent<PlayerDialogObject>();
        PDO.CheckDialogRadius();
        Destroy(this);
        Debug.Log("Force Dialog");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ForceDialog();
        }
    }

    void OnDrawGizmosSelected()
    {
        if (center == null)
            return;

        Gizmos.DrawWireSphere(center.position, radius);
    }
}
