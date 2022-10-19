using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPointTrans;
    public GameObject player;
    private void Start()
    {
        spawnPointTrans = transform.GetChild(0).transform.GetChild(0);
        player = GameObject.Find("PlayerModel");
    }

    private void OnEnable()
    {
        Darkness.onDieDarkness += RespawnPlayer;
        KillBox.onPlayerKill += RespawnPlayer;
        Checkpoint.onActivateCheckpoint += ActiveSpawnPoint;
    }
    private void OnDisable()
    {
        Darkness.onDieDarkness -= RespawnPlayer;
        KillBox.onPlayerKill -= RespawnPlayer;
        Checkpoint.onActivateCheckpoint -= ActiveSpawnPoint;
    }

    private void ActiveSpawnPoint(Transform trans)
    {
        spawnPointTrans = trans;
    }
    public void RespawnPlayer()
    {
        player.transform.position = spawnPointTrans.position;
        
    }

}
