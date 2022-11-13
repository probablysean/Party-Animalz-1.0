using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float[] playerTransform;

    public PlayerData (PlayerData player)
    {
        playerTransform = new float[3];
        playerTransform[0] = player.transform.position.x;
        playerTransform[1] = player.transform.position.y;
        playerTransform[2] = player.transform.position.z;
    }
}
