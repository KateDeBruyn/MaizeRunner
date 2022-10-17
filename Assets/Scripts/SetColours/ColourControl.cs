using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourControl : MonoBehaviour
{
    
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "RedInk")
        {
            Debug.Log("collided with red");
        }
    }

}
