using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEntry
{
    public string playerName;
    public int points;

    public InputEntry(string name, int points)
    {
        playerName = name;
        this.points = points;
    }
}