using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColour : MonoBehaviour
{
    public bool setRed;
    public bool setBlue;
    public bool setGreen;
    public bool setDefault;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && this.tag == "RedInk")
        {
            Debug.Log("hit red ink");
            setRed = true;
            setGreen = false;
            setBlue = false;
            setDefault = false;
        }
        
        if (other.gameObject.tag == "Player" && this.tag == "GreenInk")
        {
            setRed = false;
            setGreen = true;
            setBlue = false;
            setDefault = false;
        }

        if (other.gameObject.tag == "Player" && this.tag == "BlueInk"){
            setRed = false;
            setGreen = false;
            setBlue = true;
            setDefault = false;
        }

    }
}
