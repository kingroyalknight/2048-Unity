using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    private Cell[,] cell2nd = new Cell[4, 4];
    private List<Cell> emptyCell = new List<Cell> ();

	// Use this for initialization
	void Start () {
        Cell[] cell = GameObject.FindObjectsOfType<Cell>();
        foreach (Cell c in cell)
        {
            c.getsetNumber = 0;
            cell2nd[c.x, c.y] = c;
            emptyCell.Add(c);
        }
	}
	
    void random()
    {
        if (emptyCell.Count > 0)
        {
            int randomNum
        }
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void move(Move m)
    {
        Debug.Log(m.ToString());
    }
}
