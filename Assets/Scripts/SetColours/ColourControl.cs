using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourControl : MonoBehaviour
{
    // Script on the player 

    public Color col2;

    public GameObject bulletPrefabulous;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void ChangeColour(Color colIn)
    {
        col2 = colIn;
        bulletPrefabulous.GetComponent<MeshRenderer>().sharedMaterial.color = colIn;
    }

}
