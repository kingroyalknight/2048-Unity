using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Element
{
    public int num;
    public Color32 col;
}

public class Color : MonoBehaviour
{
    public static Color tit;
    public Element[] ele;
    void Awake()
    {
        tit = this;
    }
}
