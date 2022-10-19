using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColourPuzzles : MonoBehaviour
{
    public GameObject gateToOpen;
     private Color solveColor;
    public bool isPainted;
    public Transform dotweenTo;
    public List<ObjectColor> keys;
    //this color
    ColorSelector colSelect;
    public Vector3 rotateTarget;

    [SerializeField] private bool doWeRotate = false;

    private void Awake()
    {
        rotateTarget = new Vector3(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

    }

    void Start()
    {
        dotweenTo = transform.GetChild(0);
        dotweenTo.transform.parent = null;
        colSelect = GetComponent<ColorSelector>();
        solveColor = colSelect.myColor;
        foreach (ObjectColor key in keys)
        {
            Debug.Log("Solve color : " + solveColor);
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

            if (doWeRotate == false)
            {
                transform.DOMove(dotweenTo.position, 1f);
            }
            else
            {
                transform.DORotate(new Vector3(0,180,0), 0.5f);
            }
            //opem dooer
            

            Debug.Log("OOOOPEN");
        }
    }

   

   
    
}
