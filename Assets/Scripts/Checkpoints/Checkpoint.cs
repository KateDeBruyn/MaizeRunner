using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public delegate void ActivateCheckpoint(Transform spawnPoint);
    public static event ActivateCheckpoint onActivateCheckpoint;
    public Transform spawnPos;

    public void Start()
    {
        spawnPos = transform.GetChild(0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            onActivateCheckpoint(spawnPos);
        }
    }
}
