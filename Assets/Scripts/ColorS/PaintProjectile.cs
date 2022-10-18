using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintProjectile : MonoBehaviour
{
   
    private Rigidbody bulletRb;

    private Color myCol;

    private void Awake()
    {
        myCol = GetComponent<ColorSelector>().myColor;
        this.gameObject.GetComponent<MeshRenderer>().material.color = myCol;
        bulletRb = GetComponent<Rigidbody>();
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
           if (collision.gameObject.TryGetComponent(out ColorSelector othercolor))
            {
                if (collision.gameObject.TryGetComponent(out ObjectColor objcol))
                {
                    rend.material.color = myCol;
                    othercolor.myColor = myCol;
                }
                
            }
            
        }

        Destroy(gameObject);

    }

}

