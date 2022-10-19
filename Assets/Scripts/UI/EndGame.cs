using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EndGame : MonoBehaviour
{
    //[SerializeField] private GameObject textObj;
    [SerializeField] private Text text;
    //[SerializeField] private Canvas canvas;
    [SerializeField] private GameObject panel;

   private ColorManager colormanager;

    private void Awake()
    {
       
        colormanager = FindObjectOfType(typeof(ColorManager)) as ColorManager;
        panel.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        //show panel display text
        //to show text need to access color manager
        text.text = colormanager.calcValues();
        panel.SetActive(true);
        //load next scene
        

    }
}
