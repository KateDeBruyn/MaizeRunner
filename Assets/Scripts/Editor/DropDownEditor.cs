using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ColorSelector))]
public class DropDownEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ColorSelector script = (ColorSelector)target;

        GUIContent arrayList = new GUIContent("MyList");
        //script.
    }
}
