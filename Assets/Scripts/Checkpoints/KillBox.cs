using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public delegate void KillPlayer();
    public static event KillPlayer onPlayerKill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            onPlayerKill();
        }
    }
}
