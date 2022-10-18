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

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MeshRenderer rend))
        {
            if (collision.gameObject.tag == "Colourable")
            {
                Debug.Log("painted colourable");

                //Take the mesh rend of the other game object (the colourable obj) and change it to the same colour of this bullet on collision.
                rend.material.color = this.gameObject.GetComponent<MeshRenderer>().material.color;
            }
            
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

