using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Move
{
    Up, Down, Right, Left
}

public class Control : MonoBehaviour
{

    private Main main;

    void Awake()
    {
        main = GameObject.FindObjectOfType<Main>(); //connection between "Control" and "Main"
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A))
        {
            main.move(Move.Right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.D))
        {
            main.move(Move.Left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            main.move(Move.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            main.move(Move.Down);
        }
    }
}