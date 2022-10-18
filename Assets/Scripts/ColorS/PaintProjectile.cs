using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintProjectile : MonoBehaviour
{
   
    private Rigidbody bulletRb;

    private Color myCol;


    public delegate void BulletCollide();
    public static event BulletCollide onBulletCollide;
    private void Awake()
    {
        myCol = GetComponent<ColorSelector>().myColor;
      
        bulletRb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        float speed = 40f; //suitable for AR and pistol. SMG should be about 60.
        bulletRb.velocity = transform.forward * speed;
        this.gameObject.GetComponent<MeshRenderer>().material.color = myCol;


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
                    if (rend.material.color != myCol)
                    {
                        rend.material.color = myCol;
                        othercolor.myColor = myCol;
                        onBulletCollide();
                    }

                    
                }
                
            }
            
        }

        Destroy(gameObject);

    }

}

