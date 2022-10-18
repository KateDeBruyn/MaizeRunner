using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColour : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private Color col;

    void Start()
    {
        
    }

    
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Colourable")
        {
            Debug.Log("painted colourable");
        }

        other.gameObject.GetComponent<ColourControl>().ChangeColour(col);

        //if (other.gameObject.tag == "Player" && this.tag == "RedInk")
        //{
        //    other.gameObject.GetComponent<ColourControl>().ChangeColour(Color.red);
        //}

        //if (other.gameObject.tag == "Player" && this.tag == "GreenInk")
        //{
        //    other.gameObject.GetComponent<ColourControl>().ChangeColour(Color.green);
        //}

        //if (other.gameObject.tag == "Player" && this.tag == "BlueInk")
        //{
        //    other.gameObject.GetComponent<ColourControl>().ChangeColour(Color.blue);
        //}

    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.tag == "Colourable")
    //    {
    //        Debug.Log("painted colourable");
    //    }


    //    collision.gameObject.GetComponent<ColourControl>().ChangeColour(col);
    //}
}
