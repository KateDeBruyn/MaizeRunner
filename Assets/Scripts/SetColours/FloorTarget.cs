using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTarget : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedBullet")
        {
            Color floorColourRed = RedInk();
            GetComponent<Renderer>().material.color = floorColourRed;
        }

        if (collision.gameObject.tag == "BlueBullet")
        {
            Color floorColourRed = RedInk();
            GetComponent<Renderer>().material.color = floorColourRed;
        }
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
