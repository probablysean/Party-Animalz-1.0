using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
