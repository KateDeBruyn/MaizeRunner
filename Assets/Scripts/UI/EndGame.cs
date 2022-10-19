using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
   [SerializeField] private TextMesh text;
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject panel;

    public ColorManager colormanager;

    private void Awake()
    {
        colormanager = FindObjectOfType(typeof(ColorManager)) as ColorManager;


    }

    private void OnTriggerEnter(Collider other)
    {
        //show panel display text
        //to show text need to access color manager
        text.text = colormanager.calcValues();

        
        

    }
}
