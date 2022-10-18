using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public List<Color> GlobalColors;
    public List<string> statements;
    private ObjectColor[] coloureObjects;
    private List<int> Scores;


    public void calcValues()
    {
        coloureObjects = FindObjectsOfType(typeof(ObjectColor)) as ObjectColor[];
        Scores = new List<int>(GlobalColors.Count);

        foreach (ObjectColor obj in coloureObjects)
        {
            if (GlobalColors.Contains(obj.ReturnColor()))
            {
                int index = GlobalColors.IndexOf(obj.ReturnColor());
                Scores[index] += 1;
            }
        }

        int highestScore = 0;
        int highstScoreIndex = 0;
        for (int i = 0; i < Scores.Count; i++)
        {
            if (Scores[i] > highestScore)
            {
                highestScore = Scores[i];
                highstScoreIndex = i;
            }
        }

        Debug.Log(statements[highstScoreIndex]);

    }
}
