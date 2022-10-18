using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPuzzles : MonoBehaviour
{
    public GameObject gateToOpen;
    [SerializeField] private Color solveColor;
    public bool isPainted;

    public List<ObjectColor> keys;

    private SetColour setColour;

    private void Awake()
    {
        setColour = FindObjectOfType<SetColour>();
    }

    void Start()
    {
        foreach(ObjectColor key in keys)
        {
            key.correctColor = solveColor;
        }
    }

    
    void Update()
    {
        int count = 0;
        for (int i = 0; i < keys.Count; i++)
        {
            if (keys[i].AmICorrectColor())
            {
                count++;
            }
        }
        if (count == keys.Count)
        {
            //opem dooer
        }
    }


    public void CheckColour(Color colour)
    {
        colour = setColour.col;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Coloured red");
        }
    }

    private Color RedInk()
    {
        return new Color(
            r: 255,
            g: 0,
            b: 0,
            a: 0);
    }

    private Color GreenInk()
    {
        return new Color(
            r: 0,
            g: 185,
            b: 0,
            a: 0);
    }

    private Color BlueInk()
    {
        return new Color(
            r: 0,
            g: 18,
            b: 255,
            a: 0);
    }

    //ObjectColor[] objectcolors = FindObjectsOfType(typeof(ObjectColor)) as ObjectColor[];
    
}
