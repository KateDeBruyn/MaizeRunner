using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintProjectile : MonoBehaviour
{
    private Rigidbody bulletRb;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        float speed = 40f; //suitable for AR and pistol. SMG should be about 60.
        bulletRb.velocity = transform.forward * speed;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FloorTarget>() != null)
        {
            Debug.Log("hit zombie");
        }
        else if (other.gameObject.tag == "ZombieHead")
        {
            Debug.Log("hit headshot");
        }
        else
        {
            Debug.Log("hit something else");
        }

        Destroy(gameObject);
    }
}

