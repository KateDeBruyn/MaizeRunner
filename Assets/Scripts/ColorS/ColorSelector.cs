using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour
{
    public int colorIndex;
    public Color myColor;
    private ColorManager manager;
    private void Awake()
    {
        manager = FindObjectOfType(typeof(ColorManager)) as ColorManager;
        if (colorIndex != -1)
        {
            myColor = manager.GlobalColors[colorIndex];
        }
        else { myColor = GetComponent<MeshRenderer>().material.color; };

        GetComponent<MeshRenderer>().material.color = myColor;
    }
}
