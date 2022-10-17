using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintProjectile : MonoBehaviour
{
    private Rigidbody bulletRb;

    private SetColour setColourScript;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody>();

        setColourScript = FindObjectOfType<SetColour>();
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
            if (setColourScript.setRed == true)
            {
                Debug.Log("hit floor");
                Color floorColourRed = RedInk();
                GetComponent<Renderer>().material.color = floorColourRed;
            }

            if (setColourScript.setGreen == true)
            {
                Debug.Log("hit floor");
                Color floorColourGreen = GreenInk();
                GetComponent<Renderer>().material.color = floorColourGreen;
            }

            if (setColourScript.setBlue == true)
            {
                Debug.Log("hit floor");
                Color floorColourBlue = BlueInk();
                GetComponent<Renderer>().material.color = floorColourBlue;
            }
        }
        else
        {
            Debug.Log("hit something else");
        }

        Destroy(gameObject);
    }

    private Color RedInk()
    {
        return new Color(
            r: 255,
            g: 0,
            b: 0,
            a: 255);
    }

    private Color GreenInk()
    {
        return new Color(
            r: 11,
            g: 161,
            b: 0,
            a: 255);
    }

    private Color BlueInk()
    {
        return new Color(
            r: 0,
            g: 67,
            b: 255,
            a: 255);
    }
}

