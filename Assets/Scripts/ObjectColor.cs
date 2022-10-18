using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour
{
    [SerializeField] public Color correctColor;

    public bool AmICorrectColor()
    {
        // If the colour is the correct colour, return 
        return (this.gameObject.GetComponent<MeshRenderer>().material.color == correctColor);
    }
}
