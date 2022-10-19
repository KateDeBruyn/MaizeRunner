using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public List<Color> GlobalColors;
    public List<string> statements;
    public ObjectColor[] coloureObjects;
    public int[] Scores;

    public void Update()
    {
        calcValues();
    }

    public void calcValues()
    {
        coloureObjects = FindObjectsOfType(typeof(ObjectColor)) as ObjectColor[];
        Scores = new int[GlobalColors.Count];
        for (int i = 0; i < Scores.Length; i++)
        {
            Scores[i] = 0;
        }

        for (int i = 0; i < GlobalColors.Count; i++)
        {
            //Debug.Log("Color : " + i + " " + GlobalColors[i]);
        }
        foreach (ObjectColor obj in coloureObjects)
        {
           


            for (int i = 0; i < GlobalColors.Count; i++)
            {
                if (obj.ReturnColor() == GlobalColors[i])
                {
                    //Debug.Log(" COLOR OF OBJ : " + obj.ReturnColor());
                    int index = i;
                    Scores[index] += 1;
                }
            }
                
            
        }

        int highestScore = 0;
        int highstScoreIndex = 0;
        for (int i = 0; i < Scores.Length; i++)
        {
            if (Scores[i] > highestScore)
            {
                highestScore = Scores[i];
                highstScoreIndex = i;
            }
        }
        //Debug.Log(statements[highstScoreIndex]);

    }
}
