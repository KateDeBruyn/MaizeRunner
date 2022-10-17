using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourTest : MonoBehaviour
{
    // Floor colour change script
    //public GameObject floorToChange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && this.tag == "RedInk")
        {
            Color floorColourRed = RedInk();
            GetComponent<Renderer>().material.color = floorColourRed;
        }

        if (other.gameObject.tag == "Player" && this.tag == "BlueInk")
        {
            Color floorColourBlue = BlueInk();
            GetComponent<Renderer>().material.color = floorColourBlue;
        }

        if (other.gameObject.tag == "Player" && this.tag == "GreenInk")
        {
            Color floorColourGreen = GreenInk();
            GetComponent<Renderer>().material.color = floorColourGreen;
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
