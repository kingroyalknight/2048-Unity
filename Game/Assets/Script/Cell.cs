using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private int number;
    private Text text;
    private Image image;

    public int x, y;

    public int getsetNumber
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            if (number == 0)
            {
                setEmpty();
            }
            else
            {
                applyCell(number);
                setVisible();
            }
        }
    }

    void Awake()
    {
        text = GetComponentInChildren<Text> ();
        image = transform.Find("Panel").GetComponent<Image> ();
    }
    
    void applyCell(int index)
    {
        text.text = Color.cell.element[index].num.ToString(); //int to string
        image.color = Color.cell.element[index].color;
    }

    void changeType(int num)
    {
        switch (num)
        {
            case 2:
                applyCell (2);
                break;
            case 4:
                applyCell(4);
                break;
            case 8:
                applyCell(8);
                break;
            case 16:
                applyCell(16);
                break;
            case 32:
                applyCell(32);
                break;
            case 64:
                applyCell(64);
                break;
            case 128:
                applyCell(128);
                break;
            case 256:
                applyCell(256);
                break;
            case 512:
                applyCell(512);
                break;
            case 1024:
                applyCell(1024);
                break;
            case 2048:
                applyCell(2048);
                break;
            case 4096:
                applyCell(4096);
                break;
        }
    }

    private void setVisible()
    {
        text.enabled = true;
        image.enabled = true;
    }

    private void setEmpty()
    {
        text.enabled = false;
        image.enabled = false;
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