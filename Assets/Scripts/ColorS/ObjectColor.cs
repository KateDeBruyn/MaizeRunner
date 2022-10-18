using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour
{
    public Color correctColor;


    public Color ReturnColor()
    {
        return this.gameObject.GetComponent<MeshRenderer>().material.color;
    }
    public bool AmICorrectColor()
    {
      
        // If the colour is the correct colour, return 
        return (this.gameObject.GetComponent<MeshRenderer>().material.color == correctColor);
    }
}
