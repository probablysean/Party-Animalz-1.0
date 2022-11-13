using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public Player player;

    void Start()
    {
        player = GameObject.Find("Simba").GetComponent<Player>();
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SaveScene() 
    {
        SaveSystem.SavePlayer(player);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;

        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }


}
