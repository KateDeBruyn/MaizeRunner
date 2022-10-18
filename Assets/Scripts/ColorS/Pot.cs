using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    private ColorSelector mySelector;
    private void Start()
    {
        mySelector = GetComponent<ColorSelector>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.TryGetComponent(out PlayerColor plCOl))
            {
                Debug.Log("CHANGED PAINT");
                plCOl.setGunColor(mySelector.myColor);
                Debug.Log("CHANGED PAINT2");

            }
        }
    }
}
