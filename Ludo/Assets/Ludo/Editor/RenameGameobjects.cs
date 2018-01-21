using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RenameGameobjects : Editor {

    [MenuItem("GameObject/Rename")]
    public static void Rename()
    {
        GameObject[] selected = Selection.gameObjects;
        for(int i= 0; i< selected.Length; i++)
        {
            selected[i].name = "point_"+selected[i].transform.GetSiblingIndex().ToString();
        }
    }

}
