using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{

    private Text text;
    private Image ima;

    void Awake()
    {
        text = GetComponentInChildren<Text>();
        ima = transform.Find("Panel").GetComponent<Image>();
    }

    void applyColor(int index)
    {
        //text.text = Color.tit.ele[index].num;
        ima.color = Color.tit.ele[index].col;
    }

    void changeType(int num)
    {
        switch (num)
        {
            case 2:
                applyColor(2);
                break;
            case 4:
                applyColor(4);
                break;
            case 8:
                applyColor(8);
                break;
            case 16:
                applyColor(16);
                break;
            case 32:
                applyColor(32);
                break;
            case 64:
                applyColor(64);
                break;
            case 128:
                applyColor(128);
                break;
            case 256:
                applyColor(256);
                break;
            case 512:
                applyColor(512);
                break;
            case 1024:
                applyColor(1024);
                break;
            case 2048:
                applyColor(2048);
                break;
            case 4096:
                applyColor(4096);
                break;
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}