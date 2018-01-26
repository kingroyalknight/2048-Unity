using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] //see the array

public class Element
{
    public int num;
    public Color32 color;
}

public class Color : MonoBehaviour
{
    public static Color cell;
    public Element[] element;
    void Awake()
    {
        cell = this;
    }
}
